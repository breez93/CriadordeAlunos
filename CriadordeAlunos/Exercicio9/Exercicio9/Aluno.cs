using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9
{
    class Aluno
    {   
        // Membros privados

        private  int _AlunoAno;
        private  int _Alunoidade;
        private  string _AlunoNome;
        private string _AlunoCurso;



        public string SetNome(string NomedoAluno)
        {
            
            _AlunoNome = NomedoAluno;
            
            if(_AlunoNome == "Null") 
            {
                return "Aluno impreenchido";
            }
            else 
            {
                return _AlunoNome;
            }
            
        }
        public void SetIdade(int idade) 
        {
            _Alunoidade = idade;
        }
        public void SetAnoDoAluno(int ano) 
        {
            Calendario mostrarAno = new Calendario();

            _AlunoAno = ano;
       
           
            if (_AlunoAno == 1)
            {
                mostrarAno.MostrarDataInicio();
                
            }
            else if (_AlunoAno == 2)
            {
                mostrarAno.MostrarDataOutrosAnos();
            
            }
            else if (_AlunoAno == 3)
            {
                mostrarAno.MostrarFimAno();           
            }
            else
            {
                
            }
        }
        public void SetCursoDoAluno(string Curso) 
        {
            _AlunoCurso = Curso;
        }
        // Sempre que for criado um objeto tipo aluno deve abrir uma janela com as informações das datas de inicio e fim de ano




        //                                      Metodos publicos de leitura para os membros







    }
    
    
}
        

        //          Pode-se declarar apenas um dos acessors:

        //  se for declarado apenas o get a propriedade e so de leitura;
        //  se for declarado apeas o set a propriedade e so de escrita;

        // public | protected |type identifier {

        //get   {

        //  get   method code

        //set   {

        //set method code

        //  public class Aluno{

        //  private string nome;
        //  
        //  public class baseprogram{
        // 
        //      Aluno jose;
        //  } 
        //  public void SetNome (string s)   {
        //      nome = s;
        //      
        //          }     
        //                                          Construtor

        // Program ()
        // {
        //      joao = new aluno();
        //      joao.SetNome= " Aluno de inf ";
        // }

        // public string GetNome()      {
        //           return nome ;
        // }


