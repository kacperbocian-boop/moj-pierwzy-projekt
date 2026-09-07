namespace Rejestracja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnAdd_Click(object? sender, EventArgs e)
        {
            var name = txtName.Text.Trim();
            var room = txtRoom.Text.Trim();
            var issue = cmbIssue.SelectedItem as string;
            var description = txtDescription.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Proszę wpisać imię i nazwisko.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(room))
            {
                MessageBox.Show("Proszę wpisać numer sali.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(issue))
            {
                MessageBox.Show("Proszę wybrać rodzaj usterki.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var summary = new System.Text.StringBuilder();
            summary.AppendLine("Nowe zgłoszenie:");
            summary.AppendLine();
            summary.AppendLine(name);
            summary.AppendLine($"Sala: {room}");
            summary.AppendLine($"Usterka: {issue}");
            summary.AppendLine($"Opis: {description}");
            txtSummary.Text = summary.ToString();
        }

        private void btnClear_Click(object? sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtRoom.Text = string.Empty;
            if (cmbIssue.Items.Count > 0)
                cmbIssue.SelectedIndex = 0;
            txtDescription.Text = string.Empty;
            txtSummary.Text = string.Empty;
        }
    }
}
