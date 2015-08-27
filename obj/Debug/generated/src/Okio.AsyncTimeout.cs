using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okio {

	// Metadata.xml XPath class reference: path="/api/package[@name='okio']/class[@name='AsyncTimeout']"
	[global::Android.Runtime.Register ("okio/AsyncTimeout", DoNotGenerateAcw=true)]
	public partial class AsyncTimeout : global::Okio.Timeout {

		// Metadata.xml XPath class reference: path="/api/package[@name='okio']/class[@name='AsyncTimeout.Watchdog']"
		[global::Android.Runtime.Register ("okio/AsyncTimeout$Watchdog", DoNotGenerateAcw=true)]
		public sealed partial class Watchdog : global::Java.Lang.Thread {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("okio/AsyncTimeout$Watchdog", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Watchdog); }
			}

			internal Watchdog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='okio']/class[@name='AsyncTimeout.Watchdog']/constructor[@name='AsyncTimeout.Watchdog' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Watchdog ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Watchdog)) {
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
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okio/AsyncTimeout", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AsyncTimeout); }
		}

		protected AsyncTimeout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='okio']/class[@name='AsyncTimeout']/constructor[@name='AsyncTimeout' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AsyncTimeout ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AsyncTimeout)) {
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
			} finally {
			}
		}

		static IntPtr id_enter;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='AsyncTimeout']/method[@name='enter' and count(parameter)=0]"
		[Register ("enter", "()V", "")]
		public unsafe void Enter ()
		{
			if (id_enter == IntPtr.Zero)
				id_enter = JNIEnv.GetMethodID (class_ref, "enter", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_enter);
			} finally {
			}
		}

		static IntPtr id_exit;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='AsyncTimeout']/method[@name='exit' and count(parameter)=0]"
		[Register ("exit", "()Z", "")]
		public unsafe bool Exit ()
		{
			if (id_exit == IntPtr.Zero)
				id_exit = JNIEnv.GetMethodID (class_ref, "exit", "()Z");
			try {
				return JNIEnv.CallBooleanMethod  (Handle, id_exit);
			} finally {
			}
		}

		static Delegate cb_newTimeoutException_Ljava_io_IOException_;
#pragma warning disable 0169
		static Delegate GetNewTimeoutException_Ljava_io_IOException_Handler ()
		{
			if (cb_newTimeoutException_Ljava_io_IOException_ == null)
				cb_newTimeoutException_Ljava_io_IOException_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NewTimeoutException_Ljava_io_IOException_);
			return cb_newTimeoutException_Ljava_io_IOException_;
		}

		static IntPtr n_NewTimeoutException_Ljava_io_IOException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Okio.AsyncTimeout __this = global::Java.Lang.Object.GetObject<global::Okio.AsyncTimeout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.IOException p0 = global::Java.Lang.Object.GetObject<global::Java.IO.IOException> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewTimeoutException (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_newTimeoutException_Ljava_io_IOException_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='AsyncTimeout']/method[@name='newTimeoutException' and count(parameter)=1 and parameter[1][@type='java.io.IOException']]"
		[Register ("newTimeoutException", "(Ljava/io/IOException;)Ljava/io/IOException;", "GetNewTimeoutException_Ljava_io_IOException_Handler")]
		protected virtual unsafe global::Java.IO.IOException NewTimeoutException (global::Java.IO.IOException p0)
		{
			if (id_newTimeoutException_Ljava_io_IOException_ == IntPtr.Zero)
				id_newTimeoutException_Ljava_io_IOException_ = JNIEnv.GetMethodID (class_ref, "newTimeoutException", "(Ljava/io/IOException;)Ljava/io/IOException;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Java.IO.IOException __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.IO.IOException> (JNIEnv.CallObjectMethod  (Handle, id_newTimeoutException_Ljava_io_IOException_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.IO.IOException> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newTimeoutException", "(Ljava/io/IOException;)Ljava/io/IOException;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_sink_Lokio_Sink_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='AsyncTimeout']/method[@name='sink' and count(parameter)=1 and parameter[1][@type='okio.Sink']]"
		[Register ("sink", "(Lokio/Sink;)Lokio/Sink;", "")]
		public unsafe global::Okio.ISink Sink (global::Okio.ISink p0)
		{
			if (id_sink_Lokio_Sink_ == IntPtr.Zero)
				id_sink_Lokio_Sink_ = JNIEnv.GetMethodID (class_ref, "sink", "(Lokio/Sink;)Lokio/Sink;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Okio.ISink __ret = global::Java.Lang.Object.GetObject<global::Okio.ISink> (JNIEnv.CallObjectMethod  (Handle, id_sink_Lokio_Sink_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_source_Lokio_Source_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='AsyncTimeout']/method[@name='source' and count(parameter)=1 and parameter[1][@type='okio.Source']]"
		[Register ("source", "(Lokio/Source;)Lokio/Source;", "")]
		public unsafe global::Okio.ISource Source (global::Okio.ISource p0)
		{
			if (id_source_Lokio_Source_ == IntPtr.Zero)
				id_source_Lokio_Source_ = JNIEnv.GetMethodID (class_ref, "source", "(Lokio/Source;)Lokio/Source;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Okio.ISource __ret = global::Java.Lang.Object.GetObject<global::Okio.ISource> (JNIEnv.CallObjectMethod  (Handle, id_source_Lokio_Source_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_timedOut;
#pragma warning disable 0169
		static Delegate GetTimedOutHandler ()
		{
			if (cb_timedOut == null)
				cb_timedOut = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_TimedOut);
			return cb_timedOut;
		}

		static void n_TimedOut (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.AsyncTimeout __this = global::Java.Lang.Object.GetObject<global::Okio.AsyncTimeout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TimedOut ();
		}
#pragma warning restore 0169

		static IntPtr id_timedOut;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='AsyncTimeout']/method[@name='timedOut' and count(parameter)=0]"
		[Register ("timedOut", "()V", "GetTimedOutHandler")]
		protected virtual unsafe void TimedOut ()
		{
			if (id_timedOut == IntPtr.Zero)
				id_timedOut = JNIEnv.GetMethodID (class_ref, "timedOut", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_timedOut);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "timedOut", "()V"));
			} finally {
			}
		}

	}
}
