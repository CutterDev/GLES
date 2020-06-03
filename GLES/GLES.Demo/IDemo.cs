﻿
namespace GLES.Demo
{
    public interface IDemo
    {
        /// <summary>
        /// Initialisation. Do things you only need to do once here
        /// </summary>
        void Initialise();

        /// <summary>
        /// Called when the window is resized.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        void OnResize(int width, int height);

        /// <summary>
        /// Render. This is called every frame. Hopefully more than 30 FPS
        /// </summary>
        void Render(IGLPlatform glp);

        /// <summary>
        /// Tidy up and release any structures you are using
        /// </summary>
        void Finish();

    }
}