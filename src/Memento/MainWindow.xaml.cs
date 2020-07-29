using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Diagnostics.Debug;

namespace Memento
{
  /// <summary>
  /// Memento Pattern
  /// Used to track states of an object to go back and forth between.
  /// This Memento pattern will create a caretaker that contains the
  /// collection with all the Statements in it. It can add and retrieve
  /// Statements from the collection
  /// </summary>
  public partial class MainWindow : Window
  {

    // Create a CareTaker that contains the coolection.
    CareTaker careTaker = new CareTaker();

    // The originator sets the value for the statement.
    Originator originator = new Originator();

    int saveFiles = 0, currentStatement = -1;

    public MainWindow()
    {
      InitializeComponent();
    }

    private void btnSave_Click(object sender, RoutedEventArgs e)
    {
      string text = theStatement.Text;

      originator.Set(text);
      careTaker.AddMemento(originator.StoreInMemento());

      saveFiles++;
      currentStatement++;

      WriteLine($"Saved Files {saveFiles}\n");

      btnUndo.IsEnabled = true;
    }

    private void btnUndo_Click(object sender, RoutedEventArgs e)
    {
      if(currentStatement >= 0)
      {
        currentStatement--;
        string textBoxString = originator.RestoreFromMemento(careTaker.GetMemento(currentStatement));
        theStatement.Text = textBoxString;
        btnRedo.IsEnabled = true;
      }
      else
      {
        btnUndo.IsEnabled = false;
      }
    }

    private void btnRedo_Click(object sender, RoutedEventArgs e)
    {
      if ((saveFiles - 1) > currentStatement)
      {
        currentStatement++;
        string textBoxString = originator.RestoreFromMemento(careTaker.GetMemento(currentStatement));
        theStatement.Text = textBoxString;
        btnUndo.IsEnabled = false;
      }
      else
      {
        btnRedo.IsEnabled = false;
      }
      btnUndo.IsEnabled = true;
    }
  }
}
