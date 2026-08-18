namespace Balatro
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new GameApplicationContext());
        }
    }

    public class GameApplicationContext : ApplicationContext
    {
        public GameApplicationContext()
        {
            StartNewRound(4);
        }

        public void StartNewRound(int money)
        {
            var form1 = new Form1(money, this);
            this.MainForm = form1;
            form1.Show();
        }

        public void ReturnFromMarket(Form1 oldForm, int money)
        {
            var newForm = new Form1(money, this);
            this.MainForm = newForm;   
            newForm.Show();
            oldForm.Hide();
            oldForm.Dispose();         
        }
    }
}