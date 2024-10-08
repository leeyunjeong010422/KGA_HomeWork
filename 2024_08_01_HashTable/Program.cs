﻿namespace _2024_08_01_HashTable
{
    public class Program
    {
        /***********************************************************************************
        * 해시테이블 (HashTable)
        * 
        * 키 값을 해시함수로 해싱하여 해시테이블의 특정 위치로 직접 엑세스하도록 만든 방식
        * 해시 : 임의의 길이를 가진 데이터를 고정된 길이를 가진 데이터로 매핑
        ***********************************************************************************/

        // <해시테이블 구현>
        // 데이터를 담을 테이블을 이미 크게 확보해 놓은 후
        // 입력받은 키를 해싱하여 테이블 고유한 index를 계산하고 데이터를 담아 보관
        // 
        //           해싱
        //          ┌────┐
        //      2 ─→│    │─→   2
        //    998 ─→│해시│─→ 998
        //   2066 ─→│함수│─→  66
        //   8027 ─→│    │─→  27
        //          └────┘
        //
        //   [0]   [1]   [2]        [27]        [66]       [997] [998] [999]
        // ┌─────┬─────┬─────┬─  ─┬──────┬─  ─┬──────┬─  ─┬─────┬─────┬─────┐
        // │     │     │  2  │....│ 8027 │....│ 2066 │....│     │ 998 │     │
        // └─────┴─────┴─────┴─  ─┴──────┴─  ─┴──────┴─  ─┴─────┴─────┴─────┘


        // <해시함수>
        // 키값을 해싱하여 고유한 index를 만드는 함수
        // 조건으로 하나의 키값을 해싱하는 경우 반드시 항상 같은 index를 반환해야 함
        // 대표적인 해시함수로 나눗셈법이 있음
        // 예시 : 2581 → (2581 % 1000) = 581


        // <해시테이블 주의점 - 충돌>
        // 해시함수가 서로 다른 입력 값에 대해 동일한 해시테이블 주소를 반환하는 것
        // 모든 입력 값에 대해 고유한 해시 값을 만드는 것은 불가능하며 충돌은 피할 수 없음
        //
        //           해싱
        //          ┌────┐
        //   1081 ─→│해시│─→  81
        //   2081 ─→│함수│─→  81
        //          └────┘
        //
        //   [0]   [1]   [2]          [81]          [997] [998] [999]
        // ┌─────┬─────┬─────┬─  ─┬───────────┬─  ─┬─────┬─────┬─────┐
        // │     │     │     │....│ 1081 2081 │....│     │     │     │
        // └─────┴─────┴─────┴─  ─┴───────────┴─  ─┴─────┴─────┴─────┘
        //                          ↑충돌발생


        // <충돌해결방안 - 체이닝>
        // 해시 충돌이 발생하면 연결리스트로 데이터들을 연결하는 방식
        // 장점 : 해시테이블에 자료사용률에 따른 성능저하가 적음
        // 단점 : 해시테이블 외 추가적인 저장공간이 필요, 삽입삭제시 오버헤드가 발생
        //
        //   [0]   [1]   [2]        [81]      [997] [998] [999]
        // ┌─────┬─────┬─────┬─  ─┬──────┬─  ─┬─────┬─────┬─────┐
        // │     │     │     │....│  │   │....│     │     │     │
        // └─────┴─────┴─────┴─  ─┴──│───┴─  ─┴─────┴─────┴─────┘
        //                           ↓
        //                        ┌──────┬─┐ ┌──────┬─┐
        //                        │ 1081 │──→│ 2081 │ │
        //                        └──────┴─┘ └──────┴─┘


        // <충돌해결방안 - 개방주소법>
        // 해시 충돌이 발생하면 다른 빈 공간에 데이터를 삽입하는 방식
        // 해시 충돌시 선형탐색, 제곱탐색, 이중해시 등을 통해 다른 빈 공간을 선정
        // 장점 : 추가적인 저장공간이 필요하지 않음, 삽입삭제시 오버헤드가 적음
        // 단점 : 해시테이블에 자료사용률에 따른 성능저하가 발생
        //                          
        //   [0]   [1]   [2]        [81]   [82]       [997] [998] [999]
        // ┌─────┬─────┬─────┬─  ─┬──────┬──────┬─  ─┬─────┬─────┬─────┐
        // │     │     │     │....│ 1081 │      │....│     │     │     │
        // └─────┴─────┴─────┴─  ─┴──────┴──────┴─  ─┴─────┴─────┴─────┘
        //                          ↑2081(충돌)
        //
        //   [0]   [1]   [2]        [81]   [82]       [997] [998] [999]
        // ┌─────┬─────┬─────┬─  ─┬──────┬──────┬─  ─┬─────┬─────┬─────┐
        // │     │     │     │....│ 1081 │ 2081 │....│     │     │     │
        // └─────┴─────┴─────┴─  ─┴──────┴──────┴─  ─┴─────┴─────┴─────┘
        //                                 ↑(다음위치에 저장)


        // <해시테이블 효율>
        // 해시테이블의 공간 사용률이 높을 경우(통계적으로 70% 이상) 급격한 성능저하가 발생
        // 이런 경우 재해싱을 통해 공간 사용률을 낮추어 다시 효율을 확보함
        // 재해싱 : 해시테이블의 크기를 늘리고 테이블 내의 모든 데이터를 다시 해싱하여 보관
        //
        // ┌─────┬─────┬─────┬─────┬─────┐
        // │ 124 │ 258 │     │ 857 │ 858 │
        // └─────┴─────┴─────┴─────┴─────┘
        //   ↓ 재해싱
        // ┌─────┬─────┬─────┬─────┬─────┬─────┬─────┬─────┬─────┬─────┐
        // │ 124 │     │     │ 857 │ 858 │     │     │ 258 │     │     │
        // └─────┴─────┴─────┴─────┴─────┴─────┴─────┴─────┴─────┴─────┘


        // <해시테이블 시간복잡도>
        // 접근       탐색       삽입       삭제
        //  X         O(1)       O(1)       O(1)
        static void Main(string[] args)
        {
            //해시테이블 기반의 Dictionary 자료구조
            Dictionary<string, Monster> monsterDic = new Dictionary<string, Monster>();

            //삽입
            monsterDic.Add("피카츄", new Monster("피카츄", MonsterType.Electric, 80));
            monsterDic.Add("파이리", new Monster("파이리", MonsterType.Fire, 90));
            monsterDic.Add("꼬부기", new Monster("꼬부기", MonsterType.Water, 70));
            monsterDic.Add("이상해씨", new Monster("이상해씨", MonsterType.Grass, 100));            

            //삭제
            monsterDic.Remove("이상해씨");

            //탐색
            Monster find = monsterDic["피카츄"];
            Console.WriteLine($"{find.name}");
            monsterDic["피카츄"].hp = 110; //값 바꾸기

            if (monsterDic.ContainsKey("이상해씨")) //포함을 확인
            {
                Monster find1 = monsterDic["이상해씨"];
                Console.WriteLine($"{find1.name}");
            }

            monsterDic["피죤"] = new Monster("피죤", MonsterType.Wind, 70); //Add와 같이 추가 가능
        }

        public enum MonsterType { Fire, Water, Grass, Electric, Wind }

        public class Monster
        {
            public string name;
            public MonsterType type;
            public int hp;

            public Monster(string name, MonsterType type, int hp)
            {
                this.name = name;
                this.type = type;
                this.hp = hp;
            }
        }
    }
}
