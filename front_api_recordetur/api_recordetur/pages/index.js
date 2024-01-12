import "bootstrap/dist/css/bootstrap.css";
import { useEffect, useState } from "react";
import axios from "axios";
import style from '../styles/Home.module.css'

const ClientList2 = () => {
  const [clients, setClients] = useState([]);

   useEffect(() => {
  // Faça uma chamada GET para a API Spring Boot
     axios
       .get("http://recordeturapi.somee.com/api/Clientes")
       .then((response) => {
         setClients(response.data);
       })
       .catch((error) => {
         console.error("Erro ao buscar a lista de Clientes:", error);
       });
   }, []);

  return (
    <div>
    
      <h1 className={style.h1}>Lista de Clientes</h1>
      <table className="table container tabela">
        <thead>
          <tr>
            <th>Id</th>
            <th>CPF</th>
            <th>Nome</th>
            <th>Email</th>
            <th>Telefone</th>
          </tr>
        </thead>
        {clients.map((element) => (
            <tbody key={element.categoriaId}>
              <tr className={style.tabela}>
                <td>{element.clienteId}</td>
                <td>{element.cpf}</td>
                <td>{element.Nome}</td>
                <td>{element.email}</td>
                <td>{element.telefone}</td>
              </tr>
            </tbody>
          ))} 
      </table>
    </div>
  );
};

export default ClientList2;
