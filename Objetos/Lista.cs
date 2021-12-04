using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Lista
{
    public class Lista<T>
    {
        private T[] _listItems { get; set; }
        private int _indiceVago { get; set; } = 0 ;
        private int _listLenght { get; set; }
        public int Length { get { return _indiceVago; } }
        public Lista(int initialLenght = 5)
        {
            _listLenght = initialLenght;
            _listItems = new T[_listLenght];
        }

        public void Push(T item)
        {
            _VerificaNecessidadeAumentarArray();
            _listItems[_indiceVago] = item;
            _indiceVago++;
        }

        public void Log() {
            Console.WriteLine(String.Join('-', _listItems));
        }

        public T Peek() { return _listItems[_indiceVago];}

        private void _ChangeArrayLenght(int lenght)
        {
            T[] newArray = new T[lenght];
            _listLenght = lenght;
            _listItems.CopyTo(newArray, 0);
            _listItems = newArray;
        }

        private void _VerificaNecessidadeAumentarArray()
        {
            if (_listItems.Length == _indiceVago + 1)
            {
                _ChangeArrayLenght(2 * _listLenght);
            }
        }

        public void Pop()
        {
            _VerificaNecessidadeAumentarArray();
            _listItems[_indiceVago] = _listItems[_indiceVago + 1];
            _indiceVago--;
        }

        public void Remove(int indexToRemove)
        {
            if(indexToRemove < 0 || indexToRemove > _listItems.Length)
            {
                throw new IndexOutOfRangeException("Indicie deve ser maior ou igual a zero e estar dentro do tamanho do array");
            }

            for(int i = indexToRemove; i < _listItems.Length - 1; i++)
            {
                _listItems[i] = _listItems[i + 1];
            }
            _indiceVago--;
        }

        public void Remove(T item)
        {
            if(item == null)
            {
                throw new ArgumentNullException("Item nao pode ser nulo");
            }
            int indexToRemove = -1;
            for(int i = 0; i < _listItems.Length; i++)
            {
                if(item.Equals(_listItems[i]))
                {
                    indexToRemove = i;
                    break;
                }
            }

            if (indexToRemove < 0) throw new ArgumentOutOfRangeException($"Argumento {nameof(item)} nao esta presente nos items criados");

            Remove(indexToRemove);
        }

        public void PushMany(params T[] items)
        {
            foreach(T item in items)
            {
                Push(item);
            }
        }

        public T this[int indice] // pega a referencia do _listItem do lado de fora da classe
        {
            get { return _listItems[indice]; }
        } 
    }
}

/*
 public [__] this[__]
{
    get
    {
        ContaCorrente[] resultado = new ContaCorrente[__];
        for (int i = 0; i < indices.Length; i++)
        {
            int indiceDaLista = indices[i];
            resultado[i] = GetItemNoIndice(indiceDaLista);
        }
        return resultado;
    }
}

Resultado: 

ContaCorrente[], [params int[] indices] e [indices.Length].
 */

/*
 Mas, e se MinhaClasse for genérica?

class MinhaClasse<T>COPIAR CÓDIGO
O código de acesso ao ContadorEstatico deixa de compilar, precisamos especificar o argumento de tipo antes:

MinhaClasse<int>.ContadorEstatico++;
MinhaClasse<int>.ContadorEstatico++;
MinhaClasse<int>.ContadorEstatico++;

Console.WriteLine(MinhaClasse<int>.ContadorEstatico);COPIAR CÓDIGO
Aqui eu usei o argumento de tipo <int>. Bora executar? A saída será a mesma: 3. Mas, e se mudarmos este argumento genérico na hora de mostrar na tela?

Console.WriteLine( MinhaClasse<string>.ContadorEstatico );
 */
