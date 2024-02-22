# IconTintColorBehaviorBug
Minimum reproducible example repo for showcasing bug in IconTintColorBehavior in CommunityToolkit.

Steps to reproduce:
1. Run project in emulator OR physical device
2. Select "First Group" or "Second Group"
3. Click "Theme" on bottom tab
4. Change theme
5. Click "Main" on bottom tab
6. Click Back (system or top left)
7. Click "Theme" on bottom tab
8. Change theme
9. App crashes

Exception thrown:

System.Reflection.TargetInvocationException: Exception has been thrown by the target of an invocation.
 ---> System.Reflection.TargetInvocationException: Exception has been thrown by the target of an invocation.
 ---> System.Reflection.TargetInvocationException: Exception has been thrown by the target of an invocation.
 ---> System.ObjectDisposedException: Cannot access a disposed object.
Object name: 'AndroidX.AppCompat.Widget.AppCompatImageView'.
   at Java.Interop.JniPeerMembers.AssertSelf(IJavaPeerable self) in /Users/runner/work/1/s/xamarin-android/external/Java.Interop/src/Java.Interop/Java.Interop/JniPeerMembers.cs:line 153
   at Java.Interop.JniPeerMembers.JniInstanceMethods.InvokeVirtualVoidMethod(String encodedMember, IJavaPeerable self, JniArgumentValue* parameters) in /Users/runner/work/1/s/xamarin-android/external/Java.Interop/src/Java.Interop/Java.Interop/JniPeerMembers.JniInstanceMethods_Invoke.cs:line 57
   at Android.Widget.ImageView.SetColorFilter(ColorFilter cf) in /Users/runner/work/1/s/xamarin-android/src/Mono.Android/obj/Release/net8.0/android-34/mcw/Android.Widget.ImageView.cs:line 1064
   at CommunityToolkit.Maui.Behaviors.IconTintColorBehavior.<ApplyTintColor>g__SetImageViewTintColor|2_0(ImageView image, Color color)
   at CommunityToolkit.Maui.Behaviors.IconTintColorBehavior.ApplyTintColor(View element, View control)
   at CommunityToolkit.Maui.Behaviors.IconTintColorBehavior.<>c__DisplayClass0_0.<OnAttachedTo>b__0(Object s, PropertyChangedEventArgs e)
   at Microsoft.Maui.Controls.BindableObject.OnPropertyChanged(String propertyName) in D:\a\_work\1\s\src\Controls\src\Core\BindableObject.cs:line 382
   at Microsoft.Maui.Controls.BindableObject.SetValueActual(BindableProperty property, BindablePropertyContext context, Object value, Boolean currentlyApplying, SetValueFlags attributes, SetterSpecificity specificity, Boolean silent) in D:\a\_work\1\s\src\Controls\src\Core\BindableObject.cs:line 631
   at Microsoft.Maui.Controls.BindableObject.SetValueCore(BindableProperty property, Object value, SetValueFlags attributes, SetValuePrivateFlags privateAttributes, SetterSpecificity specificity) in D:\a\_work\1\s\src\Controls\src\Core\BindableObject.cs:line 559
   at Microsoft.Maui.Controls.AppThemeBinding.<>c__DisplayClass9_0.<ApplyCore>g__Set|0() in D:\a\_work\1\s\src\Controls\src\Core\AppThemeBinding.cs:line 86
   at Microsoft.Maui.Controls.DispatcherExtensions.DispatchIfRequired(IDispatcher dispatcher, Action action) in D:\a\_work\1\s\src\Controls\src\Core\DispatcherExtensions.cs:line 52
   at Microsoft.Maui.Controls.AppThemeBinding.ApplyCore(Boolean dispatch) in D:\a\_work\1\s\src\Controls\src\Core\AppThemeBinding.cs:line 70
   at Microsoft.Maui.Controls.AppThemeBinding.OnRequestedThemeChanged(Object sender, AppThemeChangedEventArgs e) in D:\a\_work\1\s\src\Controls\src\Core\AppThemeBinding.cs:line 59
   at System.Reflection.MethodBaseInvoker.InterpretedInvoke_Method(Object obj, IntPtr* args)
   at System.Reflection.MethodBaseInvoker.InvokeDirectByRefWithFewArgs(Object obj, Span`1 copyOfArgs, BindingFlags invokeAttr)
   --- End of inner exception stack trace ---
   at System.Reflection.MethodBaseInvoker.InvokeDirectByRefWithFewArgs(Object obj, Span`1 copyOfArgs, BindingFlags invokeAttr)
   at System.Reflection.MethodBaseInvoker.InvokeWithFewArgs(Object obj, BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture)
   at System.Reflection.RuntimeMethodInfo.Invoke(Object obj, BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture)
   at System.Reflection.MethodBase.Invoke(Object obj, Object[] parameters)
   at Microsoft.Maui.WeakEventManager.HandleEvent(Object sender, Object args, String eventName) in D:\a\_work\1\s\src\Core\src\WeakEventManager.cs:line 77
   at Microsoft.Maui.Controls.Application.TriggerThemeChangedActual() in D:\a\_work\1\s\src\Controls\src\Core\Application\Application.cs:line 246
   at Microsoft.Maui.Controls.Application.set_UserAppTheme(AppTheme value) in D:\a\_work\1\s\src\Controls\src\Core\Application\Application.cs:line 167
   at Maui.App.ChangeTheme(String theme) in C:\git\maui\src\-maui\App.xaml.cs:line 45
   at Maui.App.<.ctor>b__0_1(Object r, ThemeChangedMessage m) in C:\git\maui\src\-maui\App.xaml.cs:line 36
   at CommunityToolkit.Mvvm.Messaging.Internals.MessageHandlerDispatcher.For`2[[System.Object, System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e],[MauiCore.Models.Messages.ThemeChangedMessage, MauiCore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]].Invoke(Object recipient, Object message) in /_/src/CommunityToolkit.Mvvm/Messaging/Internals/MessageHandlerDispatcher.cs:line 53
   at CommunityToolkit.Mvvm.Messaging.WeakReferenceMessenger.SendAll[ThemeChangedMessage](ReadOnlySpan`1 pairs, Int32 i, ThemeChangedMessage message) in /_/src/CommunityToolkit.Mvvm/Messaging/WeakReferenceMessenger.cs:line 415
   at CommunityToolkit.Mvvm.Messaging.WeakReferenceMessenger.Send[ThemeChangedMessage,Unit](ThemeChangedMessage message, Unit token) in /_/src/CommunityToolkit.Mvvm/Messaging/WeakReferenceMessenger.cs:line 343
   at CommunityToolkit.Mvvm.Messaging.IMessengerExtensions.Send[ThemeChangedMessage](IMessenger messenger, ThemeChangedMessage message) in /_/src/CommunityToolkit.Mvvm/Messaging/IMessengerExtensions.cs:line 421
   at MauiCore.ViewModels.ProfileViewModel.OnSelectedThemeChanged(String oldValue, String newValue) in C:\git\maui\src\-maui-core\ViewModels\ProfileViewModel.cs:line 170
   at MauiCore.ViewModels.ProfileViewModel.set_SelectedTheme(String value) in C:\git\maui\src\-maui-core\CommunityToolkit.Mvvm.SourceGenerators\CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator\MauiCore.ViewModels.ProfileViewModel.g.cs:line 26
   at System.Reflection.MethodBaseInvoker.InterpretedInvoke_Method(Object obj, IntPtr* args)
   at System.Reflection.MethodBaseInvoker.InvokeDirectByRefWithFewArgs(Object obj, Span`1 copyOfArgs, BindingFlags invokeAttr)
   --- End of inner exception stack trace ---
   at System.Reflection.MethodBaseInvoker.InvokeDirectByRefWithFewArgs(Object obj, Span`1 copyOfArgs, BindingFlags invokeAttr)
   at System.Reflection.MethodBaseInvoker.InvokeWithOneArg(Object obj, BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture)
   at System.Reflection.RuntimeMethodInfo.Invoke(Object obj, BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture)
   at System.Reflection.MethodBase.Invoke(Object obj, Object[] parameters)
   at Microsoft.Maui.Controls.BindingExpression.ApplyCore(Object sourceObject, BindableObject target, BindableProperty property, Boolean fromTarget, SetterSpecificity specificity) in D:\a\_work\1\s\src\Controls\src\Core\BindingExpression.cs:line 191
   at Microsoft.Maui.Controls.BindingExpression.Apply(Boolean fromTarget) in D:\a\_work\1\s\src\Controls\src\Core\BindingExpression.cs:line 58
   at Microsoft.Maui.Controls.Binding.Apply(Boolean fromTarget) in D:\a\_work\1\s\src\Controls\src\Core\Binding.cs:line 115
   at Microsoft.Maui.Controls.BindableObject.SetValueActual(BindableProperty property, BindablePropertyContext context, Object value, Boolean currentlyApplying, SetValueFlags attributes, SetterSpecificity specificity, Boolean silent) in D:\a\_work\1\s\src\Controls\src\Core\BindableObject.cs:line 627
   at Microsoft.Maui.Controls.BindableObject.SetValueCore(BindableProperty property, Object value, SetValueFlags attributes, SetValuePrivateFlags privateAttributes, SetterSpecificity specificity) in D:\a\_work\1\s\src\Controls\src\Core\BindableObject.cs:line 559
   at Microsoft.Maui.Controls.BindableObject.SetValue(BindableProperty property, Object value) in D:\a\_work\1\s\src\Controls\src\Core\BindableObject.cs:line 464
   at Microsoft.Maui.Controls.RadioButtonGroupController.HandleRadioButtonGroupSelectionChanged(RadioButton selected, RadioButtonGroupSelectionChanged args) in D:\a\_work\1\s\src\Controls\src\Core\RadioButton\RadioButtonGroupController.cs:line 52
   at System.Reflection.MethodBaseInvoker.InterpretedInvoke_Method(Object obj, IntPtr* args)
   at System.Reflection.MethodBaseInvoker.InvokeDirectByRefWithFewArgs(Object obj, Span`1 copyOfArgs, BindingFlags invokeAttr)
   --- End of inner exception stack trace ---
   at System.Reflection.MethodBaseInvoker.InvokeDirectByRefWithFewArgs(Object obj, Span`1 copyOfArgs, BindingFlags invokeAttr)
   at System.Reflection.MethodBaseInvoker.InvokeWithFewArgs(Object obj, BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture)
   at System.Reflection.RuntimeMethodInfo.Invoke(Object obj, BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture)
   at System.Reflection.MethodBase.Invoke(Object obj, Object[] parameters)
   at Microsoft.Maui.Controls.MessagingCenter.Subscription.InvokeCallback(Object sender, Object args) in D:\a\_work\1\s\src\Controls\src\Core\MessagingCenter.cs:line 98
   at Microsoft.Maui.Controls.MessagingCenter.InnerSend(String message, Type senderType, Type argType, Object sender, Object args) in D:\a\_work\1\s\src\Controls\src\Core\MessagingCenter.cs:line 221
   at Microsoft.Maui.Controls.MessagingCenter.Microsoft.Maui.Controls.IMessagingCenter.Send[RadioButton,RadioButtonGroupSelectionChanged](RadioButton sender, String message, RadioButtonGroupSelectionChanged args) in D:\a\_work\1\s\src\Controls\src\Core\MessagingCenter.cs:line 119
   at Microsoft.Maui.Controls.MessagingCenter.Send[RadioButton,RadioButtonGroupSelectionChanged](RadioButton sender, String message, RadioButtonGroupSelectionChanged args) in D:\a\_work\1\s\src\Controls\src\Core\MessagingCenter.cs:line 112
   at Microsoft.Maui.Controls.RadioButtonGroup.UpdateRadioButtonGroup(RadioButton radioButton) in D:\a\_work\1\s\src\Controls\src\Core\RadioButton\RadioButtonGroup.cs:line 64
   at Microsoft.Maui.Controls.RadioButton.OnIsCheckedPropertyChanged(Boolean isChecked) in D:\a\_work\1\s\src\Controls\src\Core\RadioButton\RadioButton.cs:line 377
   at Microsoft.Maui.Controls.RadioButton.<>c.<.cctor>b__145_1(BindableObject b, Object o, Object n) in D:\a\_work\1\s\src\Controls\src\Core\RadioButton\RadioButton.cs:line 65
   at Microsoft.Maui.Controls.BindableObject.SetValueActual(BindableProperty property, BindablePropertyContext context, Object value, Boolean currentlyApplying, SetValueFlags attributes, SetterSpecificity specificity, Boolean silent) in D:\a\_work\1\s\src\Controls\src\Core\BindableObject.cs:line 633
   at Microsoft.Maui.Controls.BindableObject.SetValueCore(BindableProperty property, Object value, SetValueFlags attributes, SetValuePrivateFlags privateAttributes, SetterSpecificity specificity) in D:\a\_work\1\s\src\Controls\src\Core\BindableObject.cs:line 559
   at Microsoft.Maui.Controls.BindableObject.SetValue(BindableProperty property, Object value, SetterSpecificity specificity) in D:\a\_work\1\s\src\Controls\src\Core\BindableObject.cs:line 493
   at Microsoft.Maui.Controls.RadioButton.SelectRadioButton(Object sender, EventArgs e) in D:\a\_work\1\s\src\Controls\src\Core\RadioButton\RadioButton.cs:line 371
   at Microsoft.Maui.Controls.TapGestureRecognizer.SendTapped(View sender, Func`2 getPosition) in D:\a\_work\1\s\src\Controls\src\Core\TapGestureRecognizer.cs:line 62
   at Microsoft.Maui.Controls.Platform.TapGestureHandler.OnTap(Int32 count, MotionEvent e) in D:\a\_work\1\s\src\Controls\src\Core\Platform\Android\TapGestureHandler.cs:line 69
   at Microsoft.Maui.Controls.Platform.InnerGestureListener.Android.Views.GestureDetector.IOnGestureListener.OnSingleTapUp(MotionEvent e) in D:\a\_work\1\s\src\Controls\src\Core\Platform\Android\InnerGestureListener.cs:line 161
   at Android.Views.GestureDetector.IOnGestureListenerInvoker.n_OnSingleTapUp_Landroid_view_MotionEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_e) in /Users/runner/work/1/s/xamarin-android/src/Mono.Android/obj/Release/net8.0/android-34/mcw/Android.Views.GestureDetector.cs:line 721
   at Android.Runtime.JNINativeWrapper.Wrap_JniMarshal_PPL_Z(_JniMarshal_PPL_Z callback, IntPtr jnienv, IntPtr klazz, IntPtr p0) in /Users/runner/work/1/s/xamarin-android/src/Mono.Android/Android.Runtime/JNINativeWrapper.g.cs:line 136
