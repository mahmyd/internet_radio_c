using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

using System.Text;

namespace InternetRadio.UI
{
    public class RadioButtonChanger
    {
        public static void RadioButton(List<RadioButton> buttons)
        {
            if (!buttons.Any(rb => rb.Checked))
            {
                buttons[0].Checked = true;
                return;
            }
            var checkedIndex = buttons.IndexOf(buttons.First(rb => rb.Checked));
            buttons.ForEach(rb => rb.Checked = false);
            buttons[(checkedIndex + 1) % 3].Checked = true;
        }
    }
}
