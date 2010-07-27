/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.39
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.doubango.tinyWRAP;

public class CallEvent extends SipEvent {
  private long swigCPtr;

  protected CallEvent(long cPtr, boolean cMemoryOwn) {
    super(tinyWRAPJNI.SWIGCallEventUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(CallEvent obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if(swigCPtr != 0 && swigCMemOwn) {
      swigCMemOwn = false;
      tinyWRAPJNI.delete_CallEvent(swigCPtr);
    }
    swigCPtr = 0;
    super.delete();
  }

  public tsip_invite_event_type_t getType() {
    return tsip_invite_event_type_t.swigToEnum(tinyWRAPJNI.CallEvent_getType(swigCPtr, this));
  }

  public twrap_media_type_t getMediaType() {
    return twrap_media_type_t.swigToEnum(tinyWRAPJNI.CallEvent_getMediaType(swigCPtr, this));
  }

  public CallSession getSession() {
    long cPtr = tinyWRAPJNI.CallEvent_getSession(swigCPtr, this);
    return (cPtr == 0) ? null : new CallSession(cPtr, false);
  }

  public CallSession takeSessionOwnership() {
    long cPtr = tinyWRAPJNI.CallEvent_takeSessionOwnership(swigCPtr, this);
    return (cPtr == 0) ? null : new CallSession(cPtr, true);
  }

}
