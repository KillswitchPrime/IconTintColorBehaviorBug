using System;
using Microsoft.Maui.Controls;

namespace IconTintColorBehaviorBug;

public partial class SubPage : ContentPage
{
    public SubPage(SubPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
        MemoryLabel.Text = $"Memory: {GC.GetTotalMemory(false) / 1024} KB";
    }
}