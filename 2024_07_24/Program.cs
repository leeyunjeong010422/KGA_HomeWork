namespace _2024_07_24
{

    public class Program
    {

            static void Main(string[] args)
            {

            Inventory<Potion> pointInventory = new(10); //클래스명을 선언하고 <어떤타입> 명시적으로 기재
                                                        //이후엔 기존 인스턴스를 생성하는 것처럼 만들면 됨
                                                        //아이템을 상속받지 않는 타입으로 제네릭 클래스의 인스턴스를 만들려고 하면 오류 발생

            pointInventory.Add(new Potion("체력 포션")); //아이템 추가
            pointInventory.Add(new Potion("마나 포션"));
            pointInventory.Add(new Potion("경험치 포션"));
            pointInventory.Add(new Potion("활력 포션"));

            pointInventory.Remove(); //아이템 삭제
            pointInventory.Remove();

            pointInventory.PrintItemNames(); //아이템 출력

            }
        }
    }

public abstract class Item //Item이라는 클래스를 만들고
{
    public string Name { get; set; } //내부 필드로는 아이템의 이름을 가지고

    public Item(string name) //생성자에서 이름 필드를 초기화
    {
        Name = name;
    } 
}

public class Potion : Item //포션은 Item에 상속
{
    public Potion(string name) : base(name) { } //생성자로 이름이 초기화
}

//T에는 아이템을 상속받은 클래스만 넣을 수 있음
public class Inventory<T> where T : Item //클래스를 제네릭으로 선언하고 Item만 상속 받을 수 있게 제약사항을 걸어둠
{
    private T[] _list; //아이템을 담을 배열 선언
    private int _index; //배열의 데이터를 저장할 정수형 인덱스 변수 선언

    public Inventory(int size) //생성자에서 사이즈를 입력 받아
    {
        _list = new T[size]; //배열 인스턴스 생성
    }

    public void Add(T item) //인벤토리에 아이템 추가
    {
        if (_index < _list.Length) //인덱스가 배열의 길이 내부에 있을 때만 아이템을 더함
        {
            _list[_index] = item;
            _index++;
        }
    }

    public void Remove() //인벤토리에 아이템 삭제
    {
        if (_index > 0) //현재 인덱스에서 한 칸 뒤로 이동하고 null로 처리
        {
            _index--;
            _list[_index] = null;
        }
    }

    public void PrintItemNames() //인벤토리에 보관 중인 아이템 출력
    {
        Console.WriteLine("<아이템 목록>");

        foreach (T item in _list) //배열을 순회하면서 null이 아니라면 아이템의 이름을 출력
        {
            if(item != null)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}