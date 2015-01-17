using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Samsung.Android.Sdk.Pass.Support.V1 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.samsung.android.sdk.pass.support.v1']/class[@name='FingerprintManagerProxyFactory']"
	[global::Android.Runtime.Register ("com/samsung/android/sdk/pass/support/v1/FingerprintManagerProxyFactory", DoNotGenerateAcw=true)]
	public partial class FingerprintManagerProxyFactory : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/samsung/android/sdk/pass/support/v1/FingerprintManagerProxyFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FingerprintManagerProxyFactory); }
		}

		protected FingerprintManagerProxyFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.samsung.android.sdk.pass.support.v1']/class[@name='FingerprintManagerProxyFactory']/constructor[@name='FingerprintManagerProxyFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public FingerprintManagerProxyFactory () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (FingerprintManagerProxyFactory)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

	}
}
