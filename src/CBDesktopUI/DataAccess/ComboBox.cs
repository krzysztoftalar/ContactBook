using CBDesktopUI.Library.DataAccess;
using CBDesktopUI.Library.Models;

namespace CBDesktopUI.DataAccess
{
    public class ComboBox
    {
        private ComboBoxData comboBoxData;

        public ComboBox()
        {
        }

        public TypesList LoadComboBox()
        {
            comboBoxData = new ComboBoxData();

            return comboBoxData.LoadComboBox();
        }
    }
}
