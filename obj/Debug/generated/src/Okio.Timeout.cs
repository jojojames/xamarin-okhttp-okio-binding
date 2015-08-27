using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okio {

	// Metadata.xml XPath class reference: path="/api/package[@name='okio']/class[@name='Timeout']"
	[global::Android.Runtime.Register ("okio/Timeout", DoNotGenerateAcw=true)]
	public partial class Timeout : global::Java.Lang.Object {


		static IntPtr NONE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okio']/class[@name='Timeout']/field[@name='NONE']"
		[Register ("NONE")]
		public static global::Okio.Timeout None {
			get {
				if (NONE_jfieldId == IntPtr.Zero)
					NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lokio/Timeout;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NONE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okio.Timeout> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okio/Timeout", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Timeout); }
		}

		protected Timeout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='okio']/class[@name='Timeout']/constructor[@name='Timeout' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Timeout ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Timeout)) {
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

		static Delegate cb_hasDeadline;
#pragma warning disable 0169
		static Delegate GetHasDeadlineHandler ()
		{
			if (cb_hasDeadline == null)
				cb_hasDeadline = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasDeadline);
			return cb_hasDeadline;
		}

		static bool n_HasDeadline (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.Timeout __this = global::Java.Lang.Object.GetObject<global::Okio.Timeout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasDeadline;
		}
#pragma warning restore 0169

		static IntPtr id_hasDeadline;
		public virtual unsafe bool HasDeadline {
			// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Timeout']/method[@name='hasDeadline' and count(parameter)=0]"
			[Register ("hasDeadline", "()Z", "GetHasDeadlineHandler")]
			get {
				if (id_hasDeadline == IntPtr.Zero)
					id_hasDeadline = JNIEnv.GetMethodID (class_ref, "hasDeadline", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_hasDeadline);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasDeadline", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_clearDeadline;
#pragma warning disable 0169
		static Delegate GetClearDeadlineHandler ()
		{
			if (cb_clearDeadline == null)
				cb_clearDeadline = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ClearDeadline);
			return cb_clearDeadline;
		}

		static IntPtr n_ClearDeadline (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.Timeout __this = global::Java.Lang.Object.GetObject<global::Okio.Timeout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ClearDeadline ());
		}
#pragma warning restore 0169

		static IntPtr id_clearDeadline;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Timeout']/method[@name='clearDeadline' and count(parameter)=0]"
		[Register ("clearDeadline", "()Lokio/Timeout;", "GetClearDeadlineHandler")]
		public virtual unsafe global::Okio.Timeout ClearDeadline ()
		{
			if (id_clearDeadline == IntPtr.Zero)
				id_clearDeadline = JNIEnv.GetMethodID (class_ref, "clearDeadline", "()Lokio/Timeout;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Okio.Timeout> (JNIEnv.CallObjectMethod  (Handle, id_clearDeadline), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Okio.Timeout> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearDeadline", "()Lokio/Timeout;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_clearTimeout;
#pragma warning disable 0169
		static Delegate GetClearTimeoutHandler ()
		{
			if (cb_clearTimeout == null)
				cb_clearTimeout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ClearTimeout);
			return cb_clearTimeout;
		}

		static IntPtr n_ClearTimeout (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.Timeout __this = global::Java.Lang.Object.GetObject<global::Okio.Timeout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ClearTimeout ());
		}
#pragma warning restore 0169

		static IntPtr id_clearTimeout;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Timeout']/method[@name='clearTimeout' and count(parameter)=0]"
		[Register ("clearTimeout", "()Lokio/Timeout;", "GetClearTimeoutHandler")]
		public virtual unsafe global::Okio.Timeout ClearTimeout ()
		{
			if (id_clearTimeout == IntPtr.Zero)
				id_clearTimeout = JNIEnv.GetMethodID (class_ref, "clearTimeout", "()Lokio/Timeout;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Okio.Timeout> (JNIEnv.CallObjectMethod  (Handle, id_clearTimeout), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Okio.Timeout> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearTimeout", "()Lokio/Timeout;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_deadline_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Timeout']/method[@name='deadline' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("deadline", "(JLjava/util/concurrent/TimeUnit;)Lokio/Timeout;", "")]
		public unsafe global::Okio.Timeout Deadline (long p0, global::Java.Util.Concurrent.TimeUnit p1)
		{
			if (id_deadline_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_deadline_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "deadline", "(JLjava/util/concurrent/TimeUnit;)Lokio/Timeout;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Okio.Timeout __ret = global::Java.Lang.Object.GetObject<global::Okio.Timeout> (JNIEnv.CallObjectMethod  (Handle, id_deadline_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_deadlineNanoTime;
#pragma warning disable 0169
		static Delegate GetDeadlineNanoTimeHandler ()
		{
			if (cb_deadlineNanoTime == null)
				cb_deadlineNanoTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_DeadlineNanoTime);
			return cb_deadlineNanoTime;
		}

		static long n_DeadlineNanoTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.Timeout __this = global::Java.Lang.Object.GetObject<global::Okio.Timeout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DeadlineNanoTime ();
		}
#pragma warning restore 0169

		static IntPtr id_deadlineNanoTime;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Timeout']/method[@name='deadlineNanoTime' and count(parameter)=0]"
		[Register ("deadlineNanoTime", "()J", "GetDeadlineNanoTimeHandler")]
		public virtual unsafe long DeadlineNanoTime ()
		{
			if (id_deadlineNanoTime == IntPtr.Zero)
				id_deadlineNanoTime = JNIEnv.GetMethodID (class_ref, "deadlineNanoTime", "()J");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_deadlineNanoTime);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deadlineNanoTime", "()J"));
			} finally {
			}
		}

		static Delegate cb_deadlineNanoTime_J;
#pragma warning disable 0169
		static Delegate GetDeadlineNanoTime_JHandler ()
		{
			if (cb_deadlineNanoTime_J == null)
				cb_deadlineNanoTime_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_DeadlineNanoTime_J);
			return cb_deadlineNanoTime_J;
		}

		static IntPtr n_DeadlineNanoTime_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Okio.Timeout __this = global::Java.Lang.Object.GetObject<global::Okio.Timeout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeadlineNanoTime (p0));
		}
#pragma warning restore 0169

		static IntPtr id_deadlineNanoTime_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Timeout']/method[@name='deadlineNanoTime' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("deadlineNanoTime", "(J)Lokio/Timeout;", "GetDeadlineNanoTime_JHandler")]
		public virtual unsafe global::Okio.Timeout DeadlineNanoTime (long p0)
		{
			if (id_deadlineNanoTime_J == IntPtr.Zero)
				id_deadlineNanoTime_J = JNIEnv.GetMethodID (class_ref, "deadlineNanoTime", "(J)Lokio/Timeout;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Okio.Timeout> (JNIEnv.CallObjectMethod  (Handle, id_deadlineNanoTime_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Okio.Timeout> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deadlineNanoTime", "(J)Lokio/Timeout;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_throwIfReached;
#pragma warning disable 0169
		static Delegate GetThrowIfReachedHandler ()
		{
			if (cb_throwIfReached == null)
				cb_throwIfReached = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ThrowIfReached);
			return cb_throwIfReached;
		}

		static void n_ThrowIfReached (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.Timeout __this = global::Java.Lang.Object.GetObject<global::Okio.Timeout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ThrowIfReached ();
		}
#pragma warning restore 0169

		static IntPtr id_throwIfReached;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Timeout']/method[@name='throwIfReached' and count(parameter)=0]"
		[Register ("throwIfReached", "()V", "GetThrowIfReachedHandler")]
		public virtual unsafe void ThrowIfReached ()
		{
			if (id_throwIfReached == IntPtr.Zero)
				id_throwIfReached = JNIEnv.GetMethodID (class_ref, "throwIfReached", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_throwIfReached);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "throwIfReached", "()V"));
			} finally {
			}
		}

		static Delegate cb_timeout_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetInvokeTimeout_JLjava_util_concurrent_TimeUnit_Handler ()
		{
			if (cb_timeout_JLjava_util_concurrent_TimeUnit_ == null)
				cb_timeout_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr>) n_InvokeTimeout_JLjava_util_concurrent_TimeUnit_);
			return cb_timeout_JLjava_util_concurrent_TimeUnit_;
		}

		static IntPtr n_InvokeTimeout_JLjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Okio.Timeout __this = global::Java.Lang.Object.GetObject<global::Okio.Timeout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.TimeUnit p1 = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokeTimeout (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_timeout_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Timeout']/method[@name='timeout' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("timeout", "(JLjava/util/concurrent/TimeUnit;)Lokio/Timeout;", "GetInvokeTimeout_JLjava_util_concurrent_TimeUnit_Handler")]
		public virtual unsafe global::Okio.Timeout InvokeTimeout (long p0, global::Java.Util.Concurrent.TimeUnit p1)
		{
			if (id_timeout_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_timeout_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "timeout", "(JLjava/util/concurrent/TimeUnit;)Lokio/Timeout;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Okio.Timeout __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Okio.Timeout> (JNIEnv.CallObjectMethod  (Handle, id_timeout_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Okio.Timeout> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "timeout", "(JLjava/util/concurrent/TimeUnit;)Lokio/Timeout;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_timeoutNanos;
#pragma warning disable 0169
		static Delegate GetTimeoutNanosHandler ()
		{
			if (cb_timeoutNanos == null)
				cb_timeoutNanos = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_TimeoutNanos);
			return cb_timeoutNanos;
		}

		static long n_TimeoutNanos (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.Timeout __this = global::Java.Lang.Object.GetObject<global::Okio.Timeout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TimeoutNanos ();
		}
#pragma warning restore 0169

		static IntPtr id_timeoutNanos;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Timeout']/method[@name='timeoutNanos' and count(parameter)=0]"
		[Register ("timeoutNanos", "()J", "GetTimeoutNanosHandler")]
		public virtual unsafe long TimeoutNanos ()
		{
			if (id_timeoutNanos == IntPtr.Zero)
				id_timeoutNanos = JNIEnv.GetMethodID (class_ref, "timeoutNanos", "()J");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_timeoutNanos);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "timeoutNanos", "()J"));
			} finally {
			}
		}

	}
}
