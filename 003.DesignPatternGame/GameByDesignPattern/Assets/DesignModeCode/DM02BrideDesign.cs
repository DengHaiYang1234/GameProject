using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
//桥接模式 
//将抽象和实现分离，使二者可以独立的变化
class DM02BrideDesign : MonoBehaviour
{
    private void Start()
    {
        IRenderEngine reEngine = new SuperRender();

        Sphere sphrer = new Sphere(reEngine);

        Cube cube = new Cube(reEngine);

        Capsule capsule = new Capsule(reEngine);

        capsule.Draw();

        cube.Draw();

        sphrer.Draw();
    }
}


public class IShape
{
    protected string name;

    private IRenderEngine _renderEngine;

    public IShape(IRenderEngine renderEngine)
    {
        _renderEngine = renderEngine;
    }

    public void Draw()
    {
        _renderEngine.Render(name);
    }


}

public abstract class IRenderEngine
{
    public abstract void Render(string name);
}

public class Sphere : IShape
{
    public Sphere(IRenderEngine re) : base(re)
    {
        name = "Sphere";
    }

    

    //public OpenGL openGL = new OpenGL();

    //public void Draw()
    //{
    //    openGL.Render(name);
    //}
}

public class Cube : IShape
{
    public Cube(IRenderEngine re):base(re)
    {
        name = "Cube";
    }

    //public string name = "Cube";

    //public OpenGL openGL = new OpenGL();

    //public void Draw()
    //{
    //    openGL.Render(name);
    //}
}

public class Capsule : IShape
{
    public Capsule(IRenderEngine re) :base(re)
    {
        name = "Capsule";
    }

    //public string name = "Capsule";

    //public OpenGL openGL = new OpenGL();

    //public void Draw()
    //{
    //    openGL.Render(name);
    //}
}

public class OpenGL : IRenderEngine
{
    public override void Render(string name)
    {
        Debug.LogError("OpenGL 绘制出来了:" + name);
    }
}

public class DirecX : IRenderEngine
{
    public override void Render(string name)
    {
        Debug.LogError("DirecX 绘制出来了:" + name);
    }
}

public class SuperRender : IRenderEngine
{
    public override void Render(string name)
    {
        Debug.LogError("SuperRender 绘制出来了:" + name);
    }
}
