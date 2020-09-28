//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace pxr {

public class GfFrustum : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GfFrustum(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(GfFrustum obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~GfFrustum() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          USDIPCPINVOKE.delete_GfFrustum(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public GfFrustum() : this(USDIPCPINVOKE.new_GfFrustum__SWIG_0(), true) {
  }

  public GfFrustum(GfVec3d position, GfRotation rotation, GfRange2d window, GfRange1d nearFar, GfFrustum.ProjectionType projectionType, double viewDistance) : this(USDIPCPINVOKE.new_GfFrustum__SWIG_1(GfVec3d.getCPtr(position), GfRotation.getCPtr(rotation), GfRange2d.getCPtr(window), GfRange1d.getCPtr(nearFar), (int)projectionType, viewDistance), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfFrustum(GfVec3d position, GfRotation rotation, GfRange2d window, GfRange1d nearFar, GfFrustum.ProjectionType projectionType) : this(USDIPCPINVOKE.new_GfFrustum__SWIG_2(GfVec3d.getCPtr(position), GfRotation.getCPtr(rotation), GfRange2d.getCPtr(window), GfRange1d.getCPtr(nearFar), (int)projectionType), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfFrustum(GfMatrix4d camToWorldXf, GfRange2d window, GfRange1d nearFar, GfFrustum.ProjectionType projectionType, double viewDistance) : this(USDIPCPINVOKE.new_GfFrustum__SWIG_3(GfMatrix4d.getCPtr(camToWorldXf), GfRange2d.getCPtr(window), GfRange1d.getCPtr(nearFar), (int)projectionType, viewDistance), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfFrustum(GfMatrix4d camToWorldXf, GfRange2d window, GfRange1d nearFar, GfFrustum.ProjectionType projectionType) : this(USDIPCPINVOKE.new_GfFrustum__SWIG_4(GfMatrix4d.getCPtr(camToWorldXf), GfRange2d.getCPtr(window), GfRange1d.getCPtr(nearFar), (int)projectionType), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetPosition(GfVec3d position) {
    USDIPCPINVOKE.GfFrustum_SetPosition(swigCPtr, GfVec3d.getCPtr(position));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfVec3d GetPosition() {
    GfVec3d ret = new GfVec3d(USDIPCPINVOKE.GfFrustum_GetPosition(swigCPtr), false);
    return ret;
  }

  public void SetRotation(GfRotation rotation) {
    USDIPCPINVOKE.GfFrustum_SetRotation(swigCPtr, GfRotation.getCPtr(rotation));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfRotation GetRotation() {
    GfRotation ret = new GfRotation(USDIPCPINVOKE.GfFrustum_GetRotation(swigCPtr), false);
    return ret;
  }

  public void SetPositionAndRotationFromMatrix(GfMatrix4d camToWorldXf) {
    USDIPCPINVOKE.GfFrustum_SetPositionAndRotationFromMatrix(swigCPtr, GfMatrix4d.getCPtr(camToWorldXf));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetWindow(GfRange2d window) {
    USDIPCPINVOKE.GfFrustum_SetWindow(swigCPtr, GfRange2d.getCPtr(window));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfRange2d GetWindow() {
    GfRange2d ret = new GfRange2d(USDIPCPINVOKE.GfFrustum_GetWindow(swigCPtr), false);
    return ret;
  }

  public static double GetReferencePlaneDepth() {
    double ret = USDIPCPINVOKE.GfFrustum_GetReferencePlaneDepth();
    return ret;
  }

  public void SetNearFar(GfRange1d nearFar) {
    USDIPCPINVOKE.GfFrustum_SetNearFar(swigCPtr, GfRange1d.getCPtr(nearFar));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfRange1d GetNearFar() {
    GfRange1d ret = new GfRange1d(USDIPCPINVOKE.GfFrustum_GetNearFar(swigCPtr), false);
    return ret;
  }

  public void SetViewDistance(double viewDistance) {
    USDIPCPINVOKE.GfFrustum_SetViewDistance(swigCPtr, viewDistance);
  }

  public double GetViewDistance() {
    double ret = USDIPCPINVOKE.GfFrustum_GetViewDistance(swigCPtr);
    return ret;
  }

  public void SetProjectionType(GfFrustum.ProjectionType projectionType) {
    USDIPCPINVOKE.GfFrustum_SetProjectionType(swigCPtr, (int)projectionType);
  }

  public GfFrustum.ProjectionType GetProjectionType() {
    GfFrustum.ProjectionType ret = (GfFrustum.ProjectionType)USDIPCPINVOKE.GfFrustum_GetProjectionType(swigCPtr);
    return ret;
  }

  public void SetPerspective(double fieldOfViewHeight, double aspectRatio, double nearDistance, double farDistance) {
    USDIPCPINVOKE.GfFrustum_SetPerspective__SWIG_0(swigCPtr, fieldOfViewHeight, aspectRatio, nearDistance, farDistance);
  }

  public void SetPerspective(double fieldOfView, bool isFovVertical, double aspectRatio, double nearDistance, double farDistance) {
    USDIPCPINVOKE.GfFrustum_SetPerspective__SWIG_1(swigCPtr, fieldOfView, isFovVertical, aspectRatio, nearDistance, farDistance);
  }

  public bool GetPerspective(out double fieldOfViewHeight, out double aspectRatio, out double nearDistance, out double farDistance) {
    bool ret = USDIPCPINVOKE.GfFrustum_GetPerspective__SWIG_0(swigCPtr, out fieldOfViewHeight, out aspectRatio, out nearDistance, out farDistance);
    return ret;
  }

  public bool GetPerspective(bool isFovVertical, out double fieldOfView, out double aspectRatio, out double nearDistance, out double farDistance) {
    bool ret = USDIPCPINVOKE.GfFrustum_GetPerspective__SWIG_1(swigCPtr, isFovVertical, out fieldOfView, out aspectRatio, out nearDistance, out farDistance);
    return ret;
  }

  public double GetFOV(bool isFovVertical) {
    double ret = USDIPCPINVOKE.GfFrustum_GetFOV__SWIG_0(swigCPtr, isFovVertical);
    return ret;
  }

  public double GetFOV() {
    double ret = USDIPCPINVOKE.GfFrustum_GetFOV__SWIG_1(swigCPtr);
    return ret;
  }

  public void SetOrthographic(double left, double right, double bottom, double top, double nearPlane, double farPlane) {
    USDIPCPINVOKE.GfFrustum_SetOrthographic(swigCPtr, left, right, bottom, top, nearPlane, farPlane);
  }

  public bool GetOrthographic(out double left, out double right, out double bottom, out double top, out double nearPlane, out double farPlane) {
    bool ret = USDIPCPINVOKE.GfFrustum_GetOrthographic(swigCPtr, out left, out right, out bottom, out top, out nearPlane, out farPlane);
    return ret;
  }

  public void FitToSphere(GfVec3d center, double radius, double slack) {
    USDIPCPINVOKE.GfFrustum_FitToSphere__SWIG_0(swigCPtr, GfVec3d.getCPtr(center), radius, slack);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public void FitToSphere(GfVec3d center, double radius) {
    USDIPCPINVOKE.GfFrustum_FitToSphere__SWIG_1(swigCPtr, GfVec3d.getCPtr(center), radius);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfFrustum Transform(GfMatrix4d matrix) {
    GfFrustum ret = new GfFrustum(USDIPCPINVOKE.GfFrustum_Transform(swigCPtr, GfMatrix4d.getCPtr(matrix)), false);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfVec3d ComputeViewDirection() {
    GfVec3d ret = new GfVec3d(USDIPCPINVOKE.GfFrustum_ComputeViewDirection(swigCPtr), true);
    return ret;
  }

  public GfVec3d ComputeUpVector() {
    GfVec3d ret = new GfVec3d(USDIPCPINVOKE.GfFrustum_ComputeUpVector(swigCPtr), true);
    return ret;
  }

  public void ComputeViewFrame(GfVec3d side, GfVec3d up, GfVec3d view) {
    USDIPCPINVOKE.GfFrustum_ComputeViewFrame(swigCPtr, GfVec3d.getCPtr(side), GfVec3d.getCPtr(up), GfVec3d.getCPtr(view));
  }

  public GfVec3d ComputeLookAtPoint() {
    GfVec3d ret = new GfVec3d(USDIPCPINVOKE.GfFrustum_ComputeLookAtPoint(swigCPtr), true);
    return ret;
  }

  public GfMatrix4d ComputeViewMatrix() {
    GfMatrix4d ret = new GfMatrix4d(USDIPCPINVOKE.GfFrustum_ComputeViewMatrix(swigCPtr), true);
    return ret;
  }

  public GfMatrix4d ComputeViewInverse() {
    GfMatrix4d ret = new GfMatrix4d(USDIPCPINVOKE.GfFrustum_ComputeViewInverse(swigCPtr), true);
    return ret;
  }

  public GfMatrix4d ComputeProjectionMatrix() {
    GfMatrix4d ret = new GfMatrix4d(USDIPCPINVOKE.GfFrustum_ComputeProjectionMatrix(swigCPtr), true);
    return ret;
  }

  public double ComputeAspectRatio() {
    double ret = USDIPCPINVOKE.GfFrustum_ComputeAspectRatio(swigCPtr);
    return ret;
  }

  public GfVec3dVector ComputeCorners() {
    GfVec3dVector ret = new GfVec3dVector(USDIPCPINVOKE.GfFrustum_ComputeCorners(swigCPtr), true);
    return ret;
  }

  public GfVec3dVector ComputeCornersAtDistance(double d) {
    GfVec3dVector ret = new GfVec3dVector(USDIPCPINVOKE.GfFrustum_ComputeCornersAtDistance(swigCPtr, d), true);
    return ret;
  }

  public GfFrustum ComputeNarrowedFrustum(GfVec2d point, GfVec2d halfSize) {
    GfFrustum ret = new GfFrustum(USDIPCPINVOKE.GfFrustum_ComputeNarrowedFrustum__SWIG_0(swigCPtr, GfVec2d.getCPtr(point), GfVec2d.getCPtr(halfSize)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfFrustum ComputeNarrowedFrustum(GfVec3d worldPoint, GfVec2d halfSize) {
    GfFrustum ret = new GfFrustum(USDIPCPINVOKE.GfFrustum_ComputeNarrowedFrustum__SWIG_1(swigCPtr, GfVec3d.getCPtr(worldPoint), GfVec2d.getCPtr(halfSize)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfRay ComputeRay(GfVec2d windowPos) {
    GfRay ret = new GfRay(USDIPCPINVOKE.GfFrustum_ComputeRay__SWIG_0(swigCPtr, GfVec2d.getCPtr(windowPos)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfRay ComputeRay(GfVec3d worldSpacePos) {
    GfRay ret = new GfRay(USDIPCPINVOKE.GfFrustum_ComputeRay__SWIG_1(swigCPtr, GfVec3d.getCPtr(worldSpacePos)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfRay ComputePickRay(GfVec2d windowPos) {
    GfRay ret = new GfRay(USDIPCPINVOKE.GfFrustum_ComputePickRay__SWIG_0(swigCPtr, GfVec2d.getCPtr(windowPos)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfRay ComputePickRay(GfVec3d worldSpacePos) {
    GfRay ret = new GfRay(USDIPCPINVOKE.GfFrustum_ComputePickRay__SWIG_1(swigCPtr, GfVec3d.getCPtr(worldSpacePos)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Intersects(GfBBox3d bbox) {
    bool ret = USDIPCPINVOKE.GfFrustum_Intersects__SWIG_0(swigCPtr, GfBBox3d.getCPtr(bbox));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Intersects(GfVec3d point) {
    bool ret = USDIPCPINVOKE.GfFrustum_Intersects__SWIG_1(swigCPtr, GfVec3d.getCPtr(point));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Intersects(GfVec3d p0, GfVec3d p1) {
    bool ret = USDIPCPINVOKE.GfFrustum_Intersects__SWIG_2(swigCPtr, GfVec3d.getCPtr(p0), GfVec3d.getCPtr(p1));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Intersects(GfVec3d p0, GfVec3d p1, GfVec3d p2) {
    bool ret = USDIPCPINVOKE.GfFrustum_Intersects__SWIG_3(swigCPtr, GfVec3d.getCPtr(p0), GfVec3d.getCPtr(p1), GfVec3d.getCPtr(p2));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool IntersectsViewVolume(GfBBox3d bbox, GfMatrix4d vpMat) {
    bool ret = USDIPCPINVOKE.GfFrustum_IntersectsViewVolume(GfBBox3d.getCPtr(bbox), GfMatrix4d.getCPtr(vpMat));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool Equals(GfFrustum lhs, GfFrustum rhs) {
    bool ret = USDIPCPINVOKE.GfFrustum_Equals(GfFrustum.getCPtr(lhs), GfFrustum.getCPtr(rhs));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  override public int GetHashCode() {
    int ret = USDIPCPINVOKE.GfFrustum_GetHashCode(swigCPtr);
    return ret;
  }

    public static bool operator==(GfFrustum lhs, GfFrustum rhs){
      // The Swig binding glue will re-enter this operator comparing to null, so 
      // that case must be handled explicitly to avoid an infinite loop. This is still
      // not great, since it crosses the C#/C++ barrier twice. A better approache might
      // be to return a simple value from C++ that can be compared in C#.
      bool lnull = lhs as object == null;
      bool rnull = rhs as object == null;
      return (lnull == rnull) && ((lnull && rnull) || GfFrustum.Equals(lhs, rhs));
    }

    public static bool operator !=(GfFrustum lhs, GfFrustum rhs) {
        return !(lhs == rhs);
    }

    override public bool Equals(object rhs) {
      return GfFrustum.Equals(this, rhs as GfFrustum);
    }
  
  public enum ProjectionType {
    Orthographic,
    Perspective,
    ORTHOGRAPHIC = Orthographic,
    PERSPECTIVE = Perspective,
    UNDEFINED_PROJECTION_TYPE
  }

}

}