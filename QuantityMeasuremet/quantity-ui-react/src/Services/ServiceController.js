import axios from 'axios';

export default async function Convert(data) {
    try {
        var headers = {
            'Content-Type': 'application/json'
        }
        return await axios.post('https://localhost:44310/api/Measurement/Convert',data,{ headers: headers })
            .then(response => {
                console.log(response)
                return response
            })
    }
    catch (error) {
        console.log("error while converting " + error)
        return Promise.resolve(false)
    }
}

