import axios from 'axios';

export async function InchToFeet(length) {
    var headers = {
        'accept': 'application/json'
    }
    try {
        return axios.get('https://localhost:5001/api/Length/api/InchToFeet?inch='+length, { headers: headers })
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

export async function FeetToInch(length) {
    var headers = {
        'accept': 'application/json'
    }
    try {
        return axios.get('https://localhost:5001/api/Length/api/FeetToInch?feet='+length, { headers: headers })
            .then(response => {
                console.log(response)
                return response
            })
    }
    catch (error) {
        console.log("error while converting feet to Inch" + error)
        return Promise.resolve(false)
    }
}