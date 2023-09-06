import axios from "axios";

export class ContratoService {

    static serverURL = `https://localhost:7024/api/pedido`;

    static async getContrato(contratoId) {

        let dataURL = `${this.serverURL}/${contratoId}`;
        return axios.get(dataURL);
    }
}