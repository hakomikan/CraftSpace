using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpDX.Windows;

namespace CraftSpace
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            var form = new RenderForm("Test")
            {
                Width = 1280,
                Height = 800
            };
            form.Show();

            using (var app = new TestApp())
            {
                app.Ini
            }
        }
    }
}
