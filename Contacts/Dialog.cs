using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts
{
    public partial class Dialog : Form
    {
        public Dialog()
        {
            InitializeComponent();

        }

        public void FillData(DialogArgs args)
        {
            nameTextBox.Text = args.Name;
            phoneTextBox.Text = args.Phone;
            dobTextBox.Text = args.DOB;
        }

        public DialogArgs ReturnData()
        {
            DialogArgs args = new DialogArgs();

            args.Name = nameTextBox.Text;
            args.Phone = phoneTextBox.Text;
            args.DOB = dobTextBox.Text;

            return args;
        }
    }

    public class DialogArgs
    {
        private string _Name;
        private string _Phone;
        private string _DOB;

        public DialogArgs(string name = "", string phone = "", string dob = "")
        {
            _Name = name;
            _Phone = phone;
            _DOB = dob;
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }

        public string DOB
        {
            get { return _DOB; }
            set { _DOB = value; }
        }
    }
}
