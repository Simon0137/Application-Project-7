namespace Application_Project_7;

public partial class Form1 : Form
{
    private readonly char[] _correctAnswers;

    public Form1()
    {
        const string PATH = "../../../correct_answers.file";
        _correctAnswers = new char[20];

        using (var sr = new StreamReader(PATH))
        {
            for (var i = 0; i < _correctAnswers.Length; i++)
            {
                _correctAnswers[i] = sr.ReadLine()!.ToUpper()[0];
            }
        }
        
        InitializeComponent();

        label1.Text = @"";
        label2.Text = @"";
        label3.Text = @"";
        label4.Text = @"";
    }

    private void button1_Click(object sender, EventArgs e)
    {
        const string PATH = "../../../text.file";
        var studentAnswers = new char[20];
        var correctAnswers = 0;

        var labelText = "Correcting answers:\n";

        using (var sr = new StreamReader(PATH))
        {
            for (var i = 0; i < studentAnswers.Length; i++)
            {
                studentAnswers[i] = sr.ReadLine()!.ToUpper()[0];
                if (studentAnswers[i] == _correctAnswers[i])
                {
                    correctAnswers++;
                }
                else
                {
                    labelText += $"{i+1}. {studentAnswers[i]} -> {_correctAnswers[i]}\n";
                }
            }
        }
        var incorrectAnswers = 20 - correctAnswers;

        if (correctAnswers >= 15)
        {
            label1.Text = @"The student passed the exam!";
            label1.ForeColor = Color.Green;
        }
        else
        {
            label1.Text = @"The student did not pass the exam!";
            label1.ForeColor = Color.Red;
        }

        label2.Text = $@"Count of correct answers: {correctAnswers}";
        label3.Text = $@"Count of incorrect answers: {incorrectAnswers}";
        label4.Text = labelText;
    }
}