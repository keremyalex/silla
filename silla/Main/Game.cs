using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace silla.Main
{
    class Game
    {
        GameWindow window;
        Figuras.Silla silla = new Figuras.Silla(0, 0, 0);
        double theta = 0.0;

        public Game(GameWindow window)
        {
            this.window = window;

            Start();
        }
        void Start()
        {
            window.Load += loaded;
            window.Resize += resize;
            window.RenderFrame += renderF;
            window.Run(1.0 / 60.0);
        }
        
        void resize(object ob, EventArgs e)
        {
            GL.Viewport(0, 0, window.Width, window.Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            Matrix4 matrix = Matrix4.CreatePerspectiveOffCenter(-40f, 40f, -70f, 70f, 30f, 150f);
            //Matrix4 matrix = Matrix4.Perspective(45.0f, window.Width / window.Height, 1.0f, 100.0f);
            GL.LoadMatrix(ref matrix);
            GL.MatrixMode(MatrixMode.Modelview);
        }
        void renderF(object o, EventArgs e)
        {
            GL.LoadIdentity();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Translate(0.0f, 0.0f, -50.0f);

            //GL.Rotate(theta, 1.0, 0.0, 0.5);

            //silla.Rotar(theta, 1.0, 0.0, 0.5);

            silla.Dibujar();
            silla.Mover(o,e);
            window.SwapBuffers();

            //theta += 1.0;

            //if (theta > 360)
            //    theta -= 360;
        }

        void loaded(object o, EventArgs e)
        {
            GL.ClearColor(1.0f, 1.0f, 1.0f, 0.0f);
            GL.Enable(EnableCap.DepthTest);
        }
    }
}
