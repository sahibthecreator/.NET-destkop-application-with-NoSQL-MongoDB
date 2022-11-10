using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model
{
    public class TransferTicket
    {
        public void DisplayUsers(CheckBox checkBox, CheckedListBox checkedListBox)
        {
            checkedListBox.Visible = checkBox.Checked;
        }
    }
}
