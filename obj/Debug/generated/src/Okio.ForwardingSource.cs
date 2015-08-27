using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okio {

	// Metadata.xml XPath class reference: path="/api/package[@name='okio']/class[@name='ForwardingSource']"
	[global::Android.Runtime.Register ("okio/ForwardingSource", DoNotGenerateAcw=true)]
	public abstract partial class ForwardingSource : global::Java.Lang.Object, global::Okio.ISource {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okio/ForwardingSource", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ForwardingSource); }
		}

		protected ForwardingSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lokio_Source_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='okio']/class[@name='ForwardingSource']/constructor[@name='ForwardingSource' and count(parameter)=1 and parameter[1][@type='okio.Source']]"
		[Register (".ctor", "(Lokio/Source;)V", "")]
		public unsafe ForwardingSource (global::Okio.ISource p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ForwardingSource)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lokio/Source;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lokio/Source;)V", __args);
					return;
				}

				if (id_ctor_Lokio_Source_ == IntPtr.Zero)
					id_ctor_Lokio_Source_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lokio/Source;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lokio_Source_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lokio_Source_, __args);
			} finally {
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.ForwardingSource __this = global::Java.Lang.Object.GetObject<global::Okio.ForwardingSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ForwardingSource']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_close);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
			} finally {
			}
		}

		static IntPtr id_delegate;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ForwardingSource']/method[@name='delegate' and count(parameter)=0]"
		[Register ("delegate", "()Lokio/Source;", "")]
		public unsafe global::Okio.ISource Delegate ()
		{
			if (id_delegate == IntPtr.Zero)
				id_delegate = JNIEnv.GetMethodID (class_ref, "delegate", "()Lokio/Source;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okio.ISource> (JNIEnv.CallObjectMethod  (Handle, id_delegate), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_read_Lokio_Buffer_J;
#pragma warning disable 0169
		static Delegate GetRead_Lokio_Buffer_JHandler ()
		{
			if (cb_read_Lokio_Buffer_J == null)
				cb_read_Lokio_Buffer_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, long>) n_Read_Lokio_Buffer_J);
			return cb_read_Lokio_Buffer_J;
		}

		static long n_Read_Lokio_Buffer_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Okio.ForwardingSource __this = global::Java.Lang.Object.GetObject<global::Okio.ForwardingSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okio.Buffer p0 = global::Java.Lang.Object.GetObject<global::Okio.Buffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.Read (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_read_Lokio_Buffer_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ForwardingSource']/method[@name='read' and count(parameter)=2 and parameter[1][@type='okio.Buffer'] and parameter[2][@type='long']]"
		[Register ("read", "(Lokio/Buffer;J)J", "GetRead_Lokio_Buffer_JHandler")]
		public virtual unsafe long Read (global::Okio.Buffer p0, long p1)
		{
			if (id_read_Lokio_Buffer_J == IntPtr.Zero)
				id_read_Lokio_Buffer_J = JNIEnv.GetMethodID (class_ref, "read", "(Lokio/Buffer;J)J");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				long __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallLongMethod  (Handle, id_read_Lokio_Buffer_J, __args);
				else
					__ret = JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read", "(Lokio/Buffer;J)J"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_timeout;
#pragma warning disable 0169
		static Delegate GetTimeoutHandler ()
		{
			if (cb_timeout == null)
				cb_timeout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Timeout);
			return cb_timeout;
		}

		static IntPtr n_Timeout (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.ForwardingSource __this = global::Java.Lang.Object.GetObject<global::Okio.ForwardingSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Timeout ());
		}
#pragma warning restore 0169

		static IntPtr id_timeout;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ForwardingSource']/method[@name='timeout' and count(parameter)=0]"
		[Register ("timeout", "()Lokio/Timeout;", "GetTimeoutHandler")]
		public virtual unsafe global::Okio.Timeout Timeout ()
		{
			if (id_timeout == IntPtr.Zero)
				id_timeout = JNIEnv.GetMethodID (class_ref, "timeout", "()Lokio/Timeout;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Okio.Timeout> (JNIEnv.CallObjectMethod  (Handle, id_timeout), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Okio.Timeout> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "timeout", "()Lokio/Timeout;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("okio/ForwardingSource", DoNotGenerateAcw=true)]
	internal partial class ForwardingSourceInvoker : ForwardingSource {

		public ForwardingSourceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ForwardingSourceInvoker); }
		}

	}

}
