/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.39
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace org.doubango.tinyWRAP {

using System;
using System.Runtime.InteropServices;

public class ProxyAudioProducerCallback : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ProxyAudioProducerCallback(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ProxyAudioProducerCallback obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~ProxyAudioProducerCallback() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        tinyWRAPPINVOKE.delete_ProxyAudioProducerCallback(swigCPtr);
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      GC.SuppressFinalize(this);
    }
  }

  public ProxyAudioProducerCallback() : this(tinyWRAPPINVOKE.new_ProxyAudioProducerCallback(), true) {
    SwigDirectorConnect();
  }

  public virtual int prepare(int ptime, int rate, int channels) {
    int ret = ((this.GetType() == typeof(ProxyAudioProducerCallback)) ? tinyWRAPPINVOKE.ProxyAudioProducerCallback_prepare(swigCPtr, ptime, rate, channels) : tinyWRAPPINVOKE.ProxyAudioProducerCallback_prepareSwigExplicitProxyAudioProducerCallback(swigCPtr, ptime, rate, channels));
    return ret;
  }

  public virtual int start() {
    int ret = ((this.GetType() == typeof(ProxyAudioProducerCallback)) ? tinyWRAPPINVOKE.ProxyAudioProducerCallback_start(swigCPtr) : tinyWRAPPINVOKE.ProxyAudioProducerCallback_startSwigExplicitProxyAudioProducerCallback(swigCPtr));
    return ret;
  }

  public virtual int pause() {
    int ret = ((this.GetType() == typeof(ProxyAudioProducerCallback)) ? tinyWRAPPINVOKE.ProxyAudioProducerCallback_pause(swigCPtr) : tinyWRAPPINVOKE.ProxyAudioProducerCallback_pauseSwigExplicitProxyAudioProducerCallback(swigCPtr));
    return ret;
  }

  public virtual int stop() {
    int ret = ((this.GetType() == typeof(ProxyAudioProducerCallback)) ? tinyWRAPPINVOKE.ProxyAudioProducerCallback_stop(swigCPtr) : tinyWRAPPINVOKE.ProxyAudioProducerCallback_stopSwigExplicitProxyAudioProducerCallback(swigCPtr));
    return ret;
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("prepare", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateProxyAudioProducerCallback_0(SwigDirectorprepare);
    if (SwigDerivedClassHasMethod("start", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateProxyAudioProducerCallback_1(SwigDirectorstart);
    if (SwigDerivedClassHasMethod("pause", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateProxyAudioProducerCallback_2(SwigDirectorpause);
    if (SwigDerivedClassHasMethod("stop", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateProxyAudioProducerCallback_3(SwigDirectorstop);
    tinyWRAPPINVOKE.ProxyAudioProducerCallback_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3);
  }

  private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes) {
    System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(ProxyAudioProducerCallback));
    return hasDerivedMethod;
  }

  private int SwigDirectorprepare(int ptime, int rate, int channels) {
    return prepare(ptime, rate, channels);
  }

  private int SwigDirectorstart() {
    return start();
  }

  private int SwigDirectorpause() {
    return pause();
  }

  private int SwigDirectorstop() {
    return stop();
  }

  public delegate int SwigDelegateProxyAudioProducerCallback_0(int ptime, int rate, int channels);
  public delegate int SwigDelegateProxyAudioProducerCallback_1();
  public delegate int SwigDelegateProxyAudioProducerCallback_2();
  public delegate int SwigDelegateProxyAudioProducerCallback_3();

  private SwigDelegateProxyAudioProducerCallback_0 swigDelegate0;
  private SwigDelegateProxyAudioProducerCallback_1 swigDelegate1;
  private SwigDelegateProxyAudioProducerCallback_2 swigDelegate2;
  private SwigDelegateProxyAudioProducerCallback_3 swigDelegate3;

  private static Type[] swigMethodTypes0 = new Type[] { typeof(int), typeof(int), typeof(int) };
  private static Type[] swigMethodTypes1 = new Type[] {  };
  private static Type[] swigMethodTypes2 = new Type[] {  };
  private static Type[] swigMethodTypes3 = new Type[] {  };
}

}
