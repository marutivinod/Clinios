var ddValues = {};

let getDDValues = (idList) => {
    $.ajax({
        type: "GET",
        dataType: "json",
        url: baseUrl + "api/DDValues?idList=" + idList,
        async: false,
        success: function (data) {
            ddValues = data;
        }
    });
};

function convertDateTimeFieldsG(data, fields) {
    for (var i = 0; i < data.length; i++) {
        data[i] = convertDateTimeFields(data[i], fields);
    }
    return data;

}
function convertDateTimeFields(data, fields) {
    for (var i = 0; i < fields.length; i++) {
        if (data[fields[i]] == null) {
            continue;
        }
        var currentDate = new Date(data[fields[i]]);
        var currentTime = currentDate.getTime();
        var localOffset = (-1) * currentDate.getTimezoneOffset() * 60000;
        var currentTime = currentDate.getTime();
        data[fields[i]] = new Date(currentTime + localOffset);
    }
    return data;

}
function updateDateFields(data, fields) {
    for (var i = 0; i < fields.length; i++) {

        if (data[fields[i]] == null) {
            continue;
        }
        console.log(data[fields[i]].getFullYear());
        data[fields[i]] = new Date(
            data[fields[i]].getFullYear(),
            data[fields[i]].getMonth(),
            data[fields[i]].getDate(),
            new Date().getHours(),
            new Date().getMinutes(),
            new Date().getSeconds());
    }
    return data;
}
function updateDateFieldsG(data, fields) {

    for (var i = 0; i < fields.length; i++) {
        if (data[fields[i]] == null) {
            continue;
        }
        data[fields[i]] = DatetoDB(data[fields[i]]);
    }
    return data;
}

function DatefromDB(date) {
    return new Date(date.getTime() + (date.getTimezoneOffset() * 60000));
}
function DatetoDB(date) {
    return new Date(date.getTime() - (date.getTimezoneOffset() * 60000));
}

let GetDateConversion = (data, fields) => {
    fields.forEach((f) => {
        data[f] = data[f] == null ? null : new Date(data[f]);
    });
    return data;
};