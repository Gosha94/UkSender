using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace UkSender.Classes
{
    class WordSaver
    {
        private Word.Application wordApp;        
        private Word.Document wordDocument;
        private Word.Bookmarks wordBookmarks;        
        private Word.Range wordRange;
        private Word.Find find;

        public bool IsFileExist { get; private set; }

        Object missingObj = Missing.Value;
        Object trueObj = true;
        Object falseObj = false;

        public WordSaver( string pathToNewWordFile, string[] dataInForm, int monthForFileName )
        {
            try
            {
                if ( !Directory.Exists( pathToNewWordFile ) ) { CreateWordDirectory(pathToNewWordFile); FullingTemplateDataFromForm( pathToNewWordFile, monthForFileName, dataInForm ); }
                else FullingTemplateDataFromForm( pathToNewWordFile, monthForFileName, dataInForm );
            }

            catch ( Exception undefinedDirectory )
            {
                MessageBox.Show( undefinedDirectory.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }
        private void CreateWordDirectory( string path )
        {
            Directory.CreateDirectory( path );
        }

        private void FullingTemplateDataFromForm( string pathNewFile, int month, string[] meteringData )
        {
            // Создаём объект документа
            wordDocument = null;

            try
            {
                // Создаем объект Word - равносильно запуску Word
                wordApp = new Word.Application();
                // Делаем его видимым
                wordApp.Visible = false;

                // Путь до шаблона документа
                string source = CombinePathToWordTemplate() + "AttachmentTemplate.dot";
                // Открываем шаблон как новый документ
                wordDocument = wordApp.Documents.Open(source);
                wordDocument.Activate();

                // Добавляем информацию
                // wBookmarks содержит все закладки
                wordBookmarks = wordDocument.Bookmarks;
                
                int i = 0;
                
                foreach (Word.Bookmark mark in wordBookmarks)
                {
                    wordRange = mark.Range;
                    wordRange.Text = meteringData[i];
                    i++;
                }

                find = wordApp.Selection.Find;
                find.Text = "@@todayDate";
                find.Replacement.Text = DateTime.Today.ToString("d");
                find.Execute(FindText: Type.Missing, MatchCase: false, MatchWholeWord: false, MatchWildcards: false, MatchSoundsLike: missingObj, MatchAllWordForms: false, Forward: true, Wrap: Word.WdFindWrap.wdFindContinue, Format: false, ReplaceWith: missingObj, Replace: Word.WdReplace.wdReplaceAll);

                SaveDoc( pathNewFile, month );                
                ExitWord();
            }
            catch (Exception errorWord)
            {
                MessageBox.Show(errorWord.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ExitWord();
            }
        }

        private string CombinePathToWordTemplate()
        {
            string mainCatalog = AppDomain.CurrentDomain.BaseDirectory;
            return mainCatalog + "Templates\\";
        }

        private void SaveDoc(string path, int month)
        {
            if (File.Exists(path + month + ".doc"))
            {
                IsFileExist = true;
                MessageBox.Show("Файл с показаниями за текущий месяц уже существует!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                IsFileExist = false;
                Object pathToSaveObj = path + month;
                wordDocument.SaveAs(ref pathToSaveObj, Word.WdSaveFormat.wdFormatDocument, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj);
            }
        }

        private void ExitWord()
        {
            wordApp.ActiveDocument.Close();
            Object saveChanges = Word.WdSaveOptions.wdDoNotSaveChanges;
            Object originalFormat = Word.WdOriginalFormat.wdWordDocument;
            Object routeDocument = Type.Missing;
            wordApp.Quit(ref saveChanges,
                         ref originalFormat, 
                         ref routeDocument);
            wordApp = null;
        }        

    }
}
 