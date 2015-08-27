using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okio {

	// Metadata.xml XPath class reference: path="/api/package[@name='okio']/class[@name='ForwardingTimeout']"
	[global::Android.Runtime.Register ("okio/ForwardingTimeout", DoNotGenerateAcw=true)]
	public partial class ForwardingTimeout : global::Okio.Timeout {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okio/ForwardingTimeout", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ForwardingTimeout); }
		}

		protected ForwardingTimeout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lokio_Timeout_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='okio']/class[@name='ForwardingTimeout']/constructor[@name='ForwardingTimeout' and count(parameter)=1 and parameter[1][@type='okio.Timeout']]"
		[Register (".ctor", "(Lokio/Timeout;)V", "")]
		public unsafe ForwardingTimeout (global::Okio.Timeout p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ForwardingTimeout)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lokio/Timeout;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lokio/Timeout;)V", __args);
					return;
				}

				if (id_ctor_Lokio_Timeout_ == IntPtr.Zero)
					id_ctor_Lokio_Timeout_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lokio/Timeout;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lokio_Timeout_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lokio_Timeout_, __args);
			} finally {
			}
		}

		static IntPtr id_delegate;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ForwardingTimeout']/method[@name='delegate' and count(parameter)=0]"
		[Register ("delegate", "()Lokio/Timeout;", "")]
		public unsafe global::Okio.Timeout Delegate ()
		{
			if (id_delegate == IntPtr.Zero)
				id_delegate = JNIEnv.GetMethodID (class_ref, "delegate", "()Lokio/Timeout;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okio.Timeout> (JNIEnv.CallObjectMethod  (Handle, id_delegate), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_setDelegate_Lokio_Timeout_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ForwardingTimeout']/method[@name='setDelegate' and count(parameter)=1 and parameter[1][@type='okio.Timeout']]"
		[Register ("setDelegate", "(Lokio/Timeout;)Lokio/ForwardingTimeout;", "")]
		public unsafe global::Okio.ForwardingTimeout SetDelegate (global::Okio.Timeout p0)
		{
			if (id_setDelegate_Lokio_Timeout_ == IntPtr.Zero)
				id_setDelegate_Lokio_Timeout_ = JNIEnv.GetMethodID (class_ref, "setDelegate", "(Lokio/Timeout;)Lokio/ForwardingTimeout;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Okio.ForwardingTimeout __ret = global::Java.Lang.Object.GetObject<global::Okio.ForwardingTimeout> (JNIEnv.CallObjectMethod  (Handle, id_setDelegate_Lokio_Timeout_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
