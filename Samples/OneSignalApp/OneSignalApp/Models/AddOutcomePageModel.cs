using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace OneSignalApp.Models
{
   public class AddOutcomePageModel : INotifyPropertyChanged
   {
      public enum OutcomeType
      {
         Normal,
         Unique,
         WithValue
      }

      public event EventHandler PageCompleted;
      public event PropertyChangedEventHandler PropertyChanged;

      public IList<OutcomeType> Types { get; } = new List<OutcomeType> { OutcomeType.Normal, OutcomeType.Unique, OutcomeType.WithValue };
      private OutcomeType _type;
      public OutcomeType Type
      {
         get => _type;
         set
         {
            if (_type != value)
            {
               _type = value;
               OnPropertyChanged();
               OnPropertyChanged(nameof(ShouldShowValue));
            }
         }
      }

      public bool ShouldShowValue => Type == OutcomeType.WithValue;

      private string _name;
      public string Name
      {
         get => _name;
         set
         {
            if (_name != value)
            {
               _name = value;
               OnPropertyChanged();
            }
         }
      }

      private string _value;
      public string Value
      {
         get => _value;
         set
         {
            if (_value != value)
            {
               _value = value;
               OnPropertyChanged();
               OnPropertyChanged(nameof(ValueAsFloat));
            }
         }
      }

      public float? ValueAsFloat
      {
         get
         {
            if (!String.IsNullOrWhiteSpace(Value) && float.TryParse(Value, out var floatValue))
            {
               return floatValue;
            }

            return null;
         }
      }

      public string ErrorMessage
      {
         get
         {
            if (String.IsNullOrWhiteSpace(Name))
            {
               return "Name must be specified";
            }

            if (Type == OutcomeType.WithValue && ValueAsFloat == null)
            {
               return "Value must be specified as a number";
            }

            return "";
         }
      }

      public void Complete()
      {
         PageCompleted?.Invoke(this, EventArgs.Empty);
      }

      private void OnPropertyChanged([CallerMemberName] string name = "") =>
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
   }
}
