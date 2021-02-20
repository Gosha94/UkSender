# UkSender
Приложение для отправки показаний по счетчикам каждый месяц в Управляющую компанию

Используемые библиотеки:

1) Работа с БД через ORM                    - EntityFramework6
2) Сохранение в Word                        - Microsoft.Ofifce.Interop.Word
3) Дублирование показаний в табличный файл  - CsvHelper
4) Графики                                  - Oxyplot.WindowsForms
5) Отправка почты                           - System.Net.Mail

Технологии:
1) Фронтенд - WindowsForms
2) БД - MS SQL Server и PostgreSQL
3) Unit тесты - Nunit Framework
4) Условная сборка - для отделения хранения данных в Debug и Release версиях, удобства сборок и тестирования

 OxyPlot

Версия 1.0 включает:
1) Хранение данных авторизации в приложении, данных от почтовых ящиков, и другой пользовательской информации в БД MS SQL и PostgreSQL
2) Шифрование данных в БД алгоритмом AES-256
3) Авторизация в приложении через БД
4) Реализованы графики по собранным показаниям
5) Логирование работы приложения, действий пользователя в текcтовый файл log.txt
6) Автоматическое формирование шаблона вводимых показаний и автоотправка в Управляющую компанию посредством почтового клиента
7) Ограничение периодов отправки показаний в кол-ве одного раза в месяц

Future Changes:
1) Полный рефакторинг классов
2) Unit - тесты
3) Перевод работы с БД на Async Task, формы открываются с опозданием
4) Разбить приложение на слои (Бизнес логика, Доступ к данным, Представление)
5) Разбить графики по годам, 
6) Изменить хранение шаблонов показаний в формате (mYYYY)

Screenshots:

1) Авторизация

![Img alt](https://github.com/Gosha94/UkSender/raw/master/UkSender/ScreenSaves/Authorization.png)

![Img alt](https://github.com/Gosha94/UkSender/raw/master/UkSender/ScreenSaves/Error.png)

2) Главное меню

![Img alt](https://github.com/Gosha94/UkSender/raw/master/UkSender/ScreenSaves/MainMenu.png)

3) Графики

![Img alt](https://github.com/Gosha94/UkSender/raw/master/UkSender/ScreenSaves/Graphics.png)
