namespace LR4_GitDemo;

public class DetailsForm : Form
{
    private int _clickCount;
    private readonly Label _counterLabel;

    public DetailsForm()
    {
        Text = "Вторая форма";
        StartPosition = FormStartPosition.CenterParent;
        Size = new Size(440, 260);

        var title = new Label
        {
            Text = "Дополнительные функции",
            AutoSize = true,
            Font = new Font("Segoe UI", 14, FontStyle.Bold),
            Location = new Point(30, 30)
        };

        _counterLabel = new Label
        {
            Text = "Количество нажатий: 0",
            AutoSize = true,
            Location = new Point(32, 85)
        };

        var actionButton = new Button
        {
            Text = "Добавить действие",
            Size = new Size(170, 38),
            Location = new Point(30, 125)
        };
        actionButton.Click += (_, _) =>
        {
            _clickCount++;
            _counterLabel.Text = $"Количество нажатий: {_clickCount}";
        };

        var closeButton = new Button
        {
            Text = "Закрыть",
            Size = new Size(100, 38),
            Location = new Point(220, 125)
        };
        closeButton.Click += (_, _) => Close();

        Controls.AddRange([title, _counterLabel, actionButton, closeButton]);
    }
}
