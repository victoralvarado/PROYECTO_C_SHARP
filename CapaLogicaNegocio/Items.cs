/*
 * @Nombre de Clase: Items.
 * @Version: 1.0.
 * @Copyright: ToolSoft.
 * @Author Victor, Adrian, Andrea & Diego
 */
namespace CapaLogicaNegocio
{
    public class Items
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public Items(string name, string value)
        {
            Name = name;
            Value = value;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
