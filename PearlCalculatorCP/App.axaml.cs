using System;
using System.Collections.Generic;
using System.IO;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Avalonia.Platform;
using PearlCalculatorCP.Commands;
using PearlCalculatorCP.Localizer;
using PearlCalculatorCP.ViewModels;
using PearlCalculatorCP.Views;

namespace PearlCalculatorCP
{
    public class App : Application
    {
        public override void Initialize()
        {
            LoadLanuageSetting();
            CommandReg.Register();

            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow
                {
                    DataContext = new MainWindowViewModel(),
                };
            }

            base.OnFrameworkInitializationCompleted();
        }

        public override void RegisterServices()
        {
            AvaloniaLocator.CurrentMutable.Bind<IFontManagerImpl>().ToConstant(new CustomFontManagerImpl());
            base.RegisterServices();
        }

        private void LoadLanuageSetting()
        {
            var path = $"{ProgramInfo.BaseDirectory}language";
            if (File.Exists(path))
            {
                var langIdentifier = File.ReadAllText(path).TrimEnd().TrimStart();
                if (Translator.Instance.Exists(langIdentifier))
                    Translator.Instance.LoadLanguage(langIdentifier);
            }
            else
                Translator.Instance.LoadLanguage(Translator.Fallbacklanguage);
        }
    }
}
