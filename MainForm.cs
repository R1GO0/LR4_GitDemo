namespace LR4_GitDemo;

public class MainForm : Form
{
    private readonly Label _info;

    public MainForm()
    {
        Text = "Лабораторная работа №4 — Git";
        StartPosition = FormStartPosition.CenterScreen;
        Size = new Size(520, 300);

        var title = new Label
        {
            Text = "Демонстрация работы Git и GitHub",
            AutoSize = true,
            Font = new Font("Segoe UI", 15, FontStyle.Bold),
            Location = new Point(35, 35)
        };

        _info = new Label
        {
            Text = "Главная форма приложения. Версия 1.0",
            AutoSize = true,
            Location = new Point(38, 95)
        };

        var openButton = new Button
        {
            Text = "Открыть вторую форму",
            Size = new Size(190, 42),
            Location = new Point(38, 145)
        };
        openButton.Click += (_, _) =>
        {
            using var form = new DetailsForm();
            form.ShowDialog(this);
        };

        Controls.AddRange([title, _info, openButton]);
    }
}
