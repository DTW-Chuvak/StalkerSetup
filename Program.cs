using System.Diagnostics;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Controls;
using System.Drawing;
var main = new MetroForm
{
    Text = "S.T.A.L.K.E.R: install",
    Theme = MetroThemeStyle.Dark,
    Style = MetroColorStyle.Blue,
    Width = 1000,
    Height = 800,
    StartPosition = FormStartPosition.CenterScreen
};

var topControl = new MetroTabControl
{
    Dock = DockStyle.Fill,
    Theme = MetroThemeStyle.Dark,
    Style = MetroColorStyle.Blue
};


var download = new MetroTabPage {Text = " Ссылки на скачивание ", Theme = MetroThemeStyle.Dark};

var desc = new MetroLabel
{
    Text = "Вы готовы скачать файлы из Зоны?\nНажмите на кнопку 'Перейти на сайт', чтобы перейти на \nсайт загрузки.",
    Location = new System.Drawing.Point(50,20),
    Size = new System.Drawing.Size(400,150),
    Theme = MetroThemeStyle.Dark
};

var start = new MetroButton
{
    Text = "Перейти на сайт ->",
    Location = new System.Drawing.Point(50,230),
    Size = new System.Drawing.Size(180,40),
    Theme = MetroThemeStyle.Dark,
    Style = MetroColorStyle.Blue
};
start.Click += (s,e) => Process.Start(new ProcessStartInfo("https://stalker-world.ru/load/igry/7") { UseShellExecute = true});

download.Controls.Add(desc);
download.Controls.Add(start);


var aboutme = new MetroTabPage {Text = " Обо мне ", Theme = MetroThemeStyle.Dark};

var info = new MetroLabel
{
    Text = "Создано Олегом.\nСсылки актуальны на момент 28.06.2026 14:58\n\n\n\nСАЙТ И ФАЙЛЫ ЗАГРУЗКИ НЕ\nПРИНАДЛЕЖАТ МНЕ!\nЭТО ВСЕГО ЛИШЬ МЕСТО, \nГДЕ МОЖНО НАЙТИ ССЫЛКУ!\nСоздано в целях освоения C#\nи Metro Framework.",
    Location = new System.Drawing.Point(20,20),
    Size = new System.Drawing.Size(400,250),
    Theme = MetroThemeStyle.Dark
};
var infot = new MetroLabel
{
    Text = "",
    Location = new System.Drawing.Point(400,100),
    Size = new System.Drawing.Size(420,250),
    Theme = MetroThemeStyle.Dark  
};

aboutme.Controls.Add(info);
aboutme.Controls.Add(infot);

var socials = new MetroTabPage {Text = " Соц. сети ", Theme = MetroThemeStyle.Dark};

var socialus = new MetroButton
{
    Text = "Открыть мой ВК ->",
    Location = new System.Drawing.Point(20, 20),
    Size = new System.Drawing.Size(333,50),
    Theme = MetroThemeStyle.Dark,
    Style = MetroColorStyle.Blue
};
socialus.Click += (s,e) => Process.Start(new ProcessStartInfo("https://vk.com/**********") { UseShellExecute = true});
socials.Controls.Add(socialus);

var install = new MetroTabPage {Text = " Скачать тут ", Theme = MetroThemeStyle.Dark};

var here = new MetroLabel
{
    Text = "Файлы для \nзагрузки из этой \nпрограммы\nне мои. Они взяты \nс сайта\nstalker-world.ru.\nИх владелец - Anubis. А это - лишь установщик.\nНа момент 28.06.2026 16:19 торренты на раздаче.",
    Location = new System.Drawing.Point(500,20),
    Size = new System.Drawing.Size(500,500),
    Theme = MetroThemeStyle.Dark  
};
install.Controls.Add(here);

var select = new MetroComboBox
{
    Location = new System.Drawing.Point(20, 150),
    Size = new System.Drawing.Size(166, 50),
    Theme = MetroThemeStyle.Dark,
    Style = MetroColorStyle.Blue
};
select.Items.Add("Тень Чернобыля");
select.Items.Add("Чистое Небо");
select.Items.Add("Зов Припяти");
select.SelectedIndex = 0;
install.Controls.Add(select);
var submit = new MetroButton
{
    Text = "Начать установку...",
    Location = new System.Drawing.Point(186, 150),
    Size = new System.Drawing.Size(166, 50),
    Theme = MetroThemeStyle.Dark,
    Style = MetroColorStyle.Blue
};
install.Controls.Add(submit);
submit.Click += (s,e) =>
{
    string torrentFile = "";
    switch (select.SelectedIndex)
    {
        case 0:
            torrentFile = "44_Shadow_of_Chern (1).torrent";
            break;
        case 1:
            torrentFile = "74_S.T.A.L.K.E.R_.torrent";
            break;
        case 2:
            torrentFile = "46_S.T.A.L.K.E.R-C (1).torrent";
            break;
    }
    string full = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Rscr", torrentFile);

    if (System.IO.File.Exists(full))
    {
        try
        {
            Process.Start(new ProcessStartInfo(full) { UseShellExecute = true});
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Не удалось открыть торрент: {ex}.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    else
    {
        MessageBox.Show($"Файл не найден по пути: \n{full}. Проверь папку Rscr!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
};

var proga = new MetroTabPage {Text = " Необходимое ПО! ", Theme = MetroThemeStyle.Dark};

var proga1 = new MetroLabel
{
    Text = "Если вы планируете качать отсюда\n(тут только торрент), а у вас его нету, то\n вы можете скачать его тут!",
    Location = new System.Drawing.Point(20,20),
    Size = new System.Drawing.Size(500,60),
    Theme = MetroThemeStyle.Dark  
};

var proga33333 = new MetroButton
{
    Text = "Начать установку qTorrent!",
    Location = new System.Drawing.Point(20, 30),
    Size = new System.Drawing.Size(166, 40),
    Theme = MetroThemeStyle.Dark,
    Style = MetroColorStyle.Blue
};
proga.Controls.Add(proga33333);
proga33333.Click += (s,e) =>
{
    string fullstr = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Trrnt", "utorrent_installer.exe");
    if (System.IO.File.Exists(fullstr))
        {
            try
            {
                Process.Start(new ProcessStartInfo(fullstr) { UseShellExecute = true});
            }
            catch (Exception exempt)
            {
                MessageBox.Show($"Не удалось открыть торрент: {exempt}.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        else
        {
            MessageBox.Show($"Файл не найден по пути: \n{fullstr}. Проверь папку Trrnt!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
};


topControl.TabPages.Add(download);
topControl.TabPages.Add(aboutme);
topControl.TabPages.Add(socials);
topControl.TabPages.Add(install);
topControl.TabPages.Add(proga);
main.Controls.Add(topControl);
Application.Run(main);
