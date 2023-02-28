const url = 'https://localhost:7105/api/todo'

function handleOnLoad() {
    getData()
}

async function getData() {
    let response = await fetch(url)
    let json = await response.json()
    console.log(json)
}

async function handlePost() {
    console.log("inside handle post")
    const newToDo = {
        ID: 1,
        ToDo: "homework",
        Completed: false
    }
    console.log(newToDo)
    await fetch(url, {
        method: 'POST',
        body: JSON.stringify(newToDo),
        headers: {
            'Content-type': 'application/json; charset=UTF-8',
        },
    })
}

async function handlePut() {
    console.log('inside handle put')
    const updatedToDo = {
        ID: 2,
        ToDo: 'go to AIMS',
        Completed: false,
    }
    const putUrl = url + "/2"
    console.log(updatedToDo)
    await fetch(putUrl, {
        method: 'PUT',
        body: JSON.stringify(updatedToDo),
        headers: {
            'Content-type': 'application/json; charset=UTF-8',
        },
    })
}

async function handleDelete() {
    console.log('inside handle delete')

    const deleteUrl = url + '/2'
    await fetch(deleteUrl, {
        method: 'DELETE',
        headers: {
            'Content-type': 'application/json; charset=UTF-8',
        },
    })
}