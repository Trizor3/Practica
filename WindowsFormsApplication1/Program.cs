using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
    public class Employee : Person
    {
        public decimal Salary { get; set; }
        public sealed override string GetFullName()
        {
            return LastName + ", " + FirstName;
        }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IConnectionManager, SqlConnectionManager>();
            IConnectionManager connMngr = container.Resolve<IConnectionManager>();
            ISomeInterface obj = new SomeClass();
            obj.MethodA();
            obj.MethodB();

           // bool success = TestConnection(connMngr);            
            /* container.RegisterType<IHtmlCreator, HtmlInputTextCreator>("text");
            container.RegisterType<IHtmlCreator, HtmlInputCheckboxCreator>("checkbox");
            var someDbFields = new[]
            {
                new
                {
                    Text = "Please enter your name:",
                    Type = "text"
                },
                new
                {
                    Text = "Do you wish to receive offers?",
                    Type = "checkbox"
                }
            };
            // Generate the HTML...
            StringBuilder builder = new StringBuilder();
            foreach (var dbField in someDbFields)
            {
                builder.AppendLine($"<p>{dbField.Text}</p>");
                IHtmlCreator html = container.Resolve<IHtmlCreator>(dbField.Type);
                builder.AppendLine(html.CreateHtml());
            }
            Console.WriteLine(builder.ToString());
            Console.ReadKey();*/
        }
        public static void PrintFullName(Person p)
        {
            Console.WriteLine(p.GetFullName());
        }
        

        static bool TestConnection(IConnectionManager connMngr)
        {
            connMngr.Connect();
            connMngr.Close();
            return true;
        }
        private void CreateGui(IControlFactory factory)
        {
            Control textBox = factory.CreateTextBox();
            textBox.Location = new Point(10, 10);
            Controls.Add(textBox);
            Control checkBox = factory.Cre01ateCheckBox();
            checkBox.Location = new Point(10, 50);
            Controls.Add(checkBox);
        }
    }
}
