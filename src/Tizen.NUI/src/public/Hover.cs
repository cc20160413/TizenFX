/** Copyright (c) 2017 Samsung Electronics Co., Ltd.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

namespace Tizen.NUI
{
    using Tizen.NUI.BaseComponents;
    /// <summary>
    /// Hover events are a collection of points at a specific moment in time.<br>
    /// When a multi event occurs, each point represents the points that are currently being
    /// hovered or the points where a hover has stopped.<br>
    /// </summary>
    public class Hover : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal Hover(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Hover obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        //A Flag to check who called Dispose(). (By User or DisposeQueue)
        private bool isDisposeQueued = false;
        //A Flat to check if it is already disposed.
        protected bool disposed = false;

        ~Hover()
        {
            if(!isDisposeQueued)
            {
                isDisposeQueued = true;
                DisposeQueue.Instance.Add(this);
            }
        }

        public void Dispose()
        {
            //Throw excpetion if Dispose() is called in separate thread.
            if (!Window.IsInstalled())
            {
                throw new System.InvalidOperationException("This API called from separate thread. This API must be called from MainThread.");
            }

            if (isDisposeQueued)
            {
                Dispose(DisposeTypes.Implicit);
            }
            else
            {
                Dispose(DisposeTypes.Explicit);
                System.GC.SuppressFinalize(this);
            }
        }

        protected virtual void Dispose(DisposeTypes type)
        {
            if (disposed)
            {
                return;
            }

            if(type == DisposeTypes.Explicit)
            {
                //Called by User
                //Release your own managed resources here.
                //You should release all of your own disposable objects here.
            }

            //Release your own unmanaged resources here.
            //You should not access any managed member here except static instance.
            //because the execution order of Finalizes is non-deterministic.

            if (swigCPtr.Handle != global::System.IntPtr.Zero)
            {
                if (swigCMemOwn)
                {
                    swigCMemOwn = false;
                    NDalicPINVOKE.delete_Hover(swigCPtr);
                }
                swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
            }
            disposed = true;
        }


        internal static Hover GetHoverFromPtr(global::System.IntPtr cPtr)
        {
            Hover ret = new Hover(cPtr, false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// The time (in ms) that the hover event occurred.
        /// </summary>
        public uint Time
        {
            get
            {
                return time;
            }
        }

        /// <summary>
        /// Returns the ID of the device used for the Point specified.<br>
        /// Each point has a unique device ID which specifies the device used for that
        /// point. This is returned by this method.<br>
        /// </summary>
        /// <param name="point">The point required</param>
        /// <returns>The Device ID of this poin</returns>
        public int GetDeviceId(uint point)
        {
            if (point < points.Count)
            {
                return points[(int)point].DeviceId;
            }
            return -1;
        }

        /// <summary>
        /// Retrieves the State of the point specified.
        /// </summary>
        /// <param name="point">The point required</param>
        /// <returns>The state of the point specified</returns>
        public PointStateType GetState(uint point)
        {
            if (point < points.Count)
            {
                return (Tizen.NUI.PointStateType)(points[(int)point].State);
            }
            return PointStateType.Finished;
        }

        /// <summary>
        /// Retrieves the view that was underneath the point specified.
        /// </summary>
        /// <param name="point">The point required</param>
        /// <returns>The view that was underneath the point specified</returns>
        public View GetHitView(uint point)
        {
            if (point < points.Count)
            {
                return points[(int)point].HitView;
            }
            else
            {
                // Return a native empty handle
                View view = new View();
                view.Reset();
                return view;
            }
        }

        /// <summary>
        /// Retrieves the co-ordinates relative to the top-left of the hit-view at the point specified.
        /// </summary>
        /// <param name="point">The point required</param>
        /// <returns>The co-ordinates relative to the top-left of the hit-view of the point specified</returns>
        public Vector2 GetLocalPosition(uint point)
        {
            if (point < points.Count)
            {
                return points[(int)point].Local;
            }
            return new Vector2(0.0f, 0.0f);
        }

        /// <summary>
        /// Retrieves the co-ordinates relative to the top-left of the screen of the point specified.
        /// </summary>
        /// <param name="point">The point required</param>
        /// <returns>The co-ordinates relative to the top-left of the screen of the point specified</returns>
        public Vector2 GetScreenPosition(uint point)
        {
            if (point < points.Count)
            {
                return points[(int)point].Screen;
            }
            return new Vector2(0.0f, 0.0f);
        }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Hover() : this(NDalicPINVOKE.new_Hover__SWIG_0(), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="time">The time the event occurred</param>
        internal Hover(uint time) : this(NDalicPINVOKE.new_Hover__SWIG_1(time), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        private TouchPointContainer points
        {
            set
            {
                NDalicPINVOKE.Hover_points_set(swigCPtr, TouchPointContainer.getCPtr(value));
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                global::System.IntPtr cPtr = NDalicPINVOKE.Hover_points_get(swigCPtr);
                TouchPointContainer ret = (cPtr == global::System.IntPtr.Zero) ? null : new TouchPointContainer(cPtr, false);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        private uint time
        {
            set
            {
                NDalicPINVOKE.Hover_time_set(swigCPtr, value);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                uint ret = NDalicPINVOKE.Hover_time_get(swigCPtr);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// Returns the total number of points.
        /// </summary>
        /// <returns>Total number of Points</returns>
        public uint GetPointCount()
        {
            uint ret = NDalicPINVOKE.Hover_GetPointCount(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal TouchPoint GetPoint(uint point)
        {
            TouchPoint ret = new TouchPoint(NDalicPINVOKE.Hover_GetPoint(swigCPtr, point), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

    }

}