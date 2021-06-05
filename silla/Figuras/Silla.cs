using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace silla.Figuras
{
    class Silla:IntDibujo
    {
        private Double angulo, rx, ry, rz;
        private Double x, y, z, anchoX, altoY, largoZ;

        private Double position_x = 10.0;
        private Double position_y = 10.0;
        private Double position_z = 10.0;


        public Silla( double x = 0, double y = 0, double z = 0, double ancho = 1.0, double alto = 1.0, double largo = 1.0)
        {
            this.x = x; this.y = y; this.z = z;
            this.anchoX = ancho; this.altoY = alto; this.largoZ = largo;
            angulo = 0; rx = 0; ry = 0; rz = 0;
        }

      

        public void Dibujar()
        {
            GL.PushMatrix();
            GL.Scale(anchoX, altoY, largoZ);
            GL.Translate(x, y, z);
            GL.Rotate(angulo, rx, ry, rz);
            //Agregar figuras
            Pata1();
            Pata2();
            Pata3();
            Pata4();
            Espaldar();
            Tabla();

            GL.PopMatrix();
        }

        public void Rotar(double angulo, double x, double y, double z)
        {
            this.angulo = angulo; this.rx = x; this.ry = y; this.rz = z;
        }


        public void Escalar(double anchoX, double altoY, double largoZ)
        {

        }

        public void Trasladar(double x, double y, double z)
        {

        }

        public void Pata1()
        {
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(0.1f, 0.0f, 0.0f);
            //PATA 1
            GL.Vertex3((-position_x + x) * anchoX, (-position_y + y) * altoY, (position_z + z) * largoZ);
            GL.Vertex3((-position_x + 2 + x) * anchoX, (-position_y + y) * altoY, (position_z + z) * largoZ);
            GL.Vertex3(-position_x + 2 + x, position_y + y, position_z + z);
            GL.Vertex3(-position_x + x, position_y + y, position_z + z);
            GL.End();
        }

        public void Pata2()
        {
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(0.1f, 0.0f, 0.0f);
            //PATA 2
            GL.Vertex3(position_x + x, -position_y + y, position_z + z);
            GL.Vertex3(position_x - 2 + x, -position_y + y, position_z + z);
            GL.Vertex3(position_x - 2 + x, position_y + y, position_z + z);
            GL.Vertex3(position_x + x, position_y + y, position_z + z);
            GL.End();
        }

        public void Pata3()
        {
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(0.1f, 0.0f, 0.0f);
            //PATA 3
            GL.Vertex3(-position_x + x * 1.5, -position_y + y * 1.5, -position_z + z * 1.5);
            GL.Vertex3(-position_x + 2 + x * 1.5, -position_y + y * 1.5, -position_z + z * 1.5);
            GL.Vertex3(-position_x + 2 + x * 1.5, position_y + y * 1.5, -position_z + z * 1.5);
            GL.Vertex3(-position_x + x * 1.5, position_y + y * 1.5, -position_z + z * 1.5);
            GL.End();
        }

        public void Pata4()
        {
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(0.1f, 0.0f, 0.0f);
            //PATA 4
            GL.Vertex3(position_x + x * 1.5, -position_y + y * 1.5, -position_z + z * 1.5);
            GL.Vertex3(position_x - 2 + x * 1.5, -position_y + y * 1.5, -position_z + z * 1.5);
            GL.Vertex3(position_x - 2 + x * 1.5, position_y + y * 1.5, -position_z + z * 1.5);
            GL.Vertex3(position_x + x * 1.5, position_y + y * 1.5, -position_z + z * 1.5);
            GL.End();
        }

        public void Tabla()
        {
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(0.0f, 0.1f, 0.0f);
            GL.Vertex3(position_x + x, position_y + y, position_z + z);
            GL.Vertex3(position_x + x * 1.5, position_y + y * 1.5, -position_z + z * 1.5);
            GL.Vertex3(-position_x + x * 1.5, position_y + y * 1.5, -position_z + z * 1.5);
            GL.Vertex3(-position_x + x, position_y + y, position_z + z);
            GL.End();
        }

        public void Espaldar()
        {
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(0.1f, 0.0f, 0.0f);
            GL.Vertex3(-position_x + x * 1.5, position_y + y * 1.5, -position_z + z * 1.5);//abajo
            GL.Vertex3(position_x + x * 1.5, position_y + y * 1.5, -position_z + z * 1.5); //abajo
            GL.Vertex3(position_x + x * 1.5, position_y + 20 + y * 1.5, -position_z + z * 1.5);
            GL.Vertex3(-position_x + x * 1.5, position_y + 20 + y * 1.5, -position_z + z * 1.5);
            GL.End();
        }

        public void Mover(Object o, EventArgs e)
        {
            KeyboardState k = Keyboard.GetState();
            if (k.IsKeyDown(Key.A))
            {
                x--;

            }
            if (k.IsKeyDown(Key.D))
            {
                x++;

            }
            if (k.IsKeyDown(Key.W))
            {
                y++;

            }
            if (k.IsKeyDown(Key.S))
            {
                y--;

            }
        }

        
    }
}
