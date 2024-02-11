using System.Runtime.InteropServices;

namespace BotDeskTop;

public partial class Form1 : Form
{
    private bool startMapeamento = false;
    private List<Commands> commands = new List<Commands>();
    private int stepe = 1;
    public Form1()
    {
        InitializeComponent();
    }

    private void btn_map_Click(object sender, EventArgs e)
    {
        startMapeamento = true;
        btn_map.Visible = false;
        btn_stop.Visible = true;
        new Thread(new ThreadStart(Map)).Start();
    }

    private void Map()
    {
        while (startMapeamento)
        {
            int x = MousePosition.X;
            int y = MousePosition.Y;

            Invoke(delegate
            {
                lb_x.Text = "X: " + x.ToString();
                lb_y.Text = "Y: " + y.ToString();
            });
        }
    }

    private void btn_stop_map_Click(object sender, EventArgs e)
    {
        StopMap();
    }

    private void StopMap()
    {
        startMapeamento = false;
        btn_map.Visible = true;
        btn_stop.Visible = false;
    }

    private void Form1_Deactivate(object sender, EventArgs e)
    {
        if (startMapeamento)
        {
            new Thread(new ThreadStart(CallFormAgain)).Start();

            commands.Add(new Commands() { Type = "Click", Value = MousePosition });
            lv_itens.Items.Add(new ListViewItem(new string[] { stepe.ToString(), "Click", string.Concat(MousePosition.X, ",", MousePosition.Y) }));
            stepe++;
        }
    }

    private void CallFormAgain()
    {
        Invoke(delegate
        {
            if (WindowState == FormWindowState.Minimized)
                WindowState = FormWindowState.Normal;
            else
            {
                WindowState = FormWindowState.Normal;
                TopMost = true;
                BringToFront();
            }

            Activate();
        });
    }

    private void btn_add_text_Click(object sender, EventArgs e)
    {
        if (startMapeamento) StopMap();

        string promptValue = ShowDialog("Informa um valor", "RPA");
        if (!string.IsNullOrEmpty(promptValue))
        {
            commands.Add(new Commands() { Type = "Add Text", Value = promptValue });
            lv_itens.Items.Add(new ListViewItem(new string[] { stepe.ToString(), "Add Text", promptValue }));
            stepe++;
        }
    }

    public static string ShowDialog(string text, string title)
    {
        var form = new Form()
        {
            Width = 500,
            Height = 180,
            FormBorderStyle = FormBorderStyle.FixedDialog,
            Text = title,
            StartPosition = FormStartPosition.CenterScreen
        };
        Label label = new Label() { Left = 50, Top = 20, Text = text, Width = 200 };
        TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
        Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 80, DialogResult = DialogResult.OK };
        confirmation.Click += (sender, e) =>
        {
            form.Close();
        };

        form.Controls.Add(textBox);
        form.Controls.Add(confirmation);
        form.Controls.Add(label);
        form.AcceptButton = confirmation;

        return form.ShowDialog() == DialogResult.OK ? textBox.Text : "";
    }

    private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
    private const int MOUSEEVENTF_LEFTUP = 0x0004;

    [DllImport("user32.dll")]
    static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

    private void btn_start_Click(object sender, EventArgs e)
    {
        new Thread(new ThreadStart(StartProcess)).Start();
    }

    private void StartProcess()
    {
        foreach (var command in commands)
        {
            if (command.Type == "Click")
            {
                Invoke(delegate
                {
                    Cursor = new Cursor(Cursor.Current.Handle);
                    Thread.Sleep(1000);
                    Cursor.Position = command.Value;

                    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                    Thread.Sleep(100);
                    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                });
            }
            else if (command.Type == "Add Text")
            {
                SendKeys.SendWait(command.Value);
            }
        }
    }

}
