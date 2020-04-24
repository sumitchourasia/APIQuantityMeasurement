import axios from 'axios';

export default async function Convert(data) {
    try {
        var headers = {
            accept: 'application/json',
            // Content-Type: 'application/json-patch+json';
        }
        return await axios.post('https://localhost:44310/api/Measurement/Convert',data ,{ headers: headers })
            .then(response => {
                console.log(response)
                return response
            })
    }
    catch (error) {
        console.log("error while converting Inch to feet" + error)
        return Promise.resolve(false)
    }
}

