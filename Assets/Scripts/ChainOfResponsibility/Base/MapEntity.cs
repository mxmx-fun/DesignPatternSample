namespace DesignPatternSample.ChainOfResponsibility
{
    public class MapEntity
    {
        int level;
        int chapter;

        MapEntity nextMap;
        public MapEntity NextMap => nextMap;
        public void SetNextMap(MapEntity nextMap) => this.nextMap = nextMap;

        public MapEntity(int chapter, int level)
        {
            this.chapter = chapter;
            this.level = level;
            if (level < 10)
            {
                SetNextMap(new MapEntity(chapter, level + 1));
            }
        }

        public void Init()
        {
            UnityEngine.Debug.Log($"chapter:{chapter} level:{level} map Init");
        }

        public void Clear()
        {
            UnityEngine.Debug.Log($"chapter:{chapter} level:{level} map Clear");
        }

        public void Enter()
        {
            UnityEngine.Debug.Log($"chapter:{chapter} level:{level} map Enter");
        }
    }
}