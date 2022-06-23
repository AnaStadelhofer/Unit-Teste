namespace Senac
{    
    public class Usuario    
    {        
        public string Login(string pEmail, string pSenha)
        {             
            //2 etapa corrigir as msg de erros            
            if (string.IsNullOrEmpty(pEmail) || string.IsNullOrEmpty(pSenha))
            {                
                return "Preencha todos os dados!";            
            }            
            //1 Etapa            
            else if(pEmail.Equals("marcelo.petri@prof.sc.senac.br") && pSenha.Equals("123456"))
            {                
                return "Usuário logado";            
            } 
            else
            {                
                return "E-mail ou senha incorretos";            
            }      
        }  

        public bool VerificarNome(string pNome)
        {           
            if (String.IsNullOrEmpty(pNome))
            {                
                return false;
            } 
            else
            {                
                return true;            
            }        
        }  
    }
}