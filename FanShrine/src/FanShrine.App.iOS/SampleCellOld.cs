// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;

namespace FanShrine.App.iOS
{
	public partial class SampleCell : ReactiveTableViewCell, IViewFor<IArtist>
	{
        public SampleCell(IntPtr handle) : base(handle)
        {
            Debug.WriteLine("hello2");
        }

        private IArtist _viewModel;
        public IArtist ViewModel
        {
            get { return _viewModel; }
            set { this.RaiseAndSetIfChanged(ref _viewModel, value); }
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = value as IArtist; }
        }

        public void Initialize()
        {
            this.WhenAnyValue(v => v.ViewModel.Name).BindTo(
                this,
                v => v.TextLabel.Text);
        }
	}
}
