/*
  Decoratorデザインパターンは、書くクラスの責務を確実に1つにするための効果的なパターン。
  クラスで実行するものが多すぎるものの、それらの責務の結びつきが強すぎて、
  それらを他のクラスとして分割する明白な方法が無いように思えることが多々あります。

  Decoratorパターンの基本前提は、書くデコレータークラスが型のコントラクト(契約)を満たすことと、
  それらの型をコンストラクターのパラメーターとして受け取ることです。
  特定のインターフェースを実装している既存のクラスに対して機能を追加できるようになることと、
  デコレーターが(クライアントに気づかれずに)必要なインターフェースの実装としても機能することを考えると、
  これは有益な前提です。
*/

public interface IComponent
{
  void Something();
}

public class ConcreteComponent : IComponent
{
  public void Something()
  {

  }
}

public class DecoratorComponent : IComponent
{
  private readonly IComponent decoratedComponent;

  public DecoratorComponent(IComponent decoratedComponent)
  {
    this.decoratedComponent = decoreatedComponent;
  }

  public void Something()
  {
    SomethingElse();
    decoratedComponent.Something();
  }

  private void SomethingElse()
  {

  }
}

class Program
{
  static IComponent component;

  static void Main(string[] args)
  {
    /*
      ConcreteComponentクラスもDecoratorComponentクラスもどちらもIComponentを実装しているため、
      どちらも引数として渡すことが可能。
    */
    // component = new DecoratorComponent(new ConcreteComponent());
    // component = new DecoratorComponent(new DecoratorComponent());

    component.Something();
  }
}
