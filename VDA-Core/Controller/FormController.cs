using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDA_Core.Controller
{
    public class FormController
    {
        public static void CreateForm(Form form)
        {
            form.MaximizeBox = true;
            form.MinimizeBox = true;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }
        public static void CreateForm(Form form, bool hasSizingControls)
        {
            form.MaximizeBox = hasSizingControls;
            form.MinimizeBox = hasSizingControls;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }
        public static void CreateForm(Form form, bool hasSizingControls, bool maximized)
        {
            form.MaximizeBox = hasSizingControls;
            form.MinimizeBox = hasSizingControls;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.Show();

            if (maximized)
                form.WindowState = FormWindowState.Maximized;
        }

        public static void CreateDialog(Form form)
        {
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }
        public static void CreateDialog(Form form, Point position)
        {
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.Manual;
            form.ShowDialog();
            form.Location = position;
        }
        public static void CreateDialog(Form form, Form parentForm)
        {
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog(parentForm);
        }
        public static void CreateDialog(Form form, Point position, Form parentForm)
        {
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.Manual;
            form.ShowDialog(parentForm);
            form.Location = position;
        }
    }
}
