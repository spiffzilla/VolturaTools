﻿#region Using statements

using System;
using System.Windows.Forms;

#endregion

namespace WeekNumber
{
    internal static class Message
    {
        #region Internal static methods

        internal static void Show(string text, Exception ex = null)
        {
            MessageBox.Show(ex is null ? text : text + ex.ToString(), Text.ApplicationNameAndVersion,
                MessageBoxButtons.OK, ex is null ? MessageBoxIcon.Information : MessageBoxIcon.Error);
        }

        #endregion
    }
}