﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace ObservableBinding.WPF.Behavior
{
  class MainViewModel
  {
    public IObservable<string> StringStream { get; set; }
      = Observable.Interval(TimeSpan.FromSeconds(1)).Select(i => i.ToString());
  }
}
