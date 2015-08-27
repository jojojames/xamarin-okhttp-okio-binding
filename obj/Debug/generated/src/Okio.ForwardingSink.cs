using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okio {

	// Metadata.xml XPath class reference: path="/api/package[@name='okio']/class[@name='ForwardingSink']"
	[global::Android.Runtime.Register ("okio/ForwardingSink", DoNotGenerateAcw=true)]
	public abstract partial class ForwardingSink : global::Java.Lang.Object, global::Okio.ISink {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okio/ForwardingSink", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ForwardingSink); }
		}

		protected ForwardingSink (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lokio_Sink_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='okio']/class[@name='ForwardingSink']/constructor[@name='ForwardingSink' and count(parameter)=1 and parameter[1][@type='okio.Sink']]"
		[Register (".ctor", "(Lokio/Sink;)V", "")]
		public unsafe ForwardingSink (global::Okio.ISink p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ForwardingSink)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lokio/Sink;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lokio/Sink;)V", __args);
					return;
				}

				if (id_ctor_Lokio_Sink_ == IntPtr.Zero)
					id_ctor_Lokio_Sink_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lokio/Sink;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lokio_Sink_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lokio_Sink_, __args);
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
			global::Okio.ForwardingSink __this = global::Java.Lang.Object.GetObject<global::Okio.ForwardingSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ForwardingSink']/method[@name='close' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ForwardingSink']/method[@name='delegate' and count(parameter)=0]"
		[Register ("delegate", "()Lokio/Sink;", "")]
		public unsafe global::Okio.ISink Delegate ()
		{
			if (id_delegate == IntPtr.Zero)
				id_delegate = JNIEnv.GetMethodID (class_ref, "delegate", "()Lokio/Sink;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okio.ISink> (JNIEnv.CallObjectMethod  (Handle, id_delegate), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_flush;
#pragma warning disable 0169
		static Delegate GetFlushHandler ()
		{
			if (cb_flush == null)
				cb_flush = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Flush);
			return cb_flush;
		}

		static void n_Flush (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.ForwardingSink __this = global::Java.Lang.Object.GetObject<global::Okio.ForwardingSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Flush ();
		}
#pragma warning restore 0169

		static IntPtr id_flush;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ForwardingSink']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "GetFlushHandler")]
		public virtual unsafe void Flush ()
		{
			if (id_flush == IntPtr.Zero)
				id_flush = JNIEnv.GetMethodID (class_ref, "flush", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_flush);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "flush", "()V"));
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
			global::Okio.ForwardingSink __this = global::Java.Lang.Object.GetObject<global::Okio.ForwardingSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Timeout ());
		}
#pragma warning restore 0169

		static IntPtr id_timeout;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ForwardingSink']/method[@name='timeout' and count(parameter)=0]"
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

		static Delegate cb_write_Lokio_Buffer_J;
#pragma warning disable 0169
		static Delegate GetWrite_Lokio_Buffer_JHandler ()
		{
			if (cb_write_Lokio_Buffer_J == null)
				cb_write_Lokio_Buffer_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_Write_Lokio_Buffer_J);
			return cb_write_Lokio_Buffer_J;
		}

		static void n_Write_Lokio_Buffer_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Okio.ForwardingSink __this = global::Java.Lang.Object.GetObject<global::Okio.ForwardingSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okio.Buffer p0 = global::Java.Lang.Object.GetObject<global::Okio.Buffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_write_Lokio_Buffer_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ForwardingSink']/method[@name='write' and count(parameter)=2 and parameter[1][@type='okio.Buffer'] and parameter[2][@type='long']]"
		[Register ("write", "(Lokio/Buffer;J)V", "GetWrite_Lokio_Buffer_JHandler")]
		public virtual unsafe void Write (global::Okio.Buffer p0, long p1)
		{
			if (id_write_Lokio_Buffer_J == IntPtr.Zero)
				id_write_Lokio_Buffer_J = JNIEnv.GetMethodID (class_ref, "write", "(Lokio/Buffer;J)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_write_Lokio_Buffer_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Lokio/Buffer;J)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("okio/ForwardingSink", DoNotGenerateAcw=true)]
	internal partial class ForwardingSinkInvoker : ForwardingSink {

		public ForwardingSinkInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ForwardingSinkInvoker); }
		}

	}

}
