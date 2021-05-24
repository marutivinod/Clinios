var dbName = "myDatabase";
var db = new Dexie(dbName);
db.version(1).stores({
    table1: '++lId,Id,FirstName,LastName',
    table2: '++lId,Id,Name,City,State',
    chestpain: '++lId,CreatedBy,CreatedDate,Id,IsActive,ModeOfArrivalId,ModifiedBy,Modified_Date,PatientId,PreArvlNote,PreArvlTime,RefFrom,RevisitReason,TraigeDoneby,TriageTime,proto'
    //table 3 with all columns in single quote
});
//pass jquery data

function insertRecord(tableName, record) {
    debugger;
    if (record == null) {
        if (tableName == "table1") {
            record = { Id: 1, LastName: 'C1', FirstName: 'Srinivas'};
        }
        if (tableName == "table2") {
            record = { Id: 1, City: 'Tpty', Name: 'Srinivas1',  State: 'AP' };
        }
        if (tableName == "chestpain") {
            record = {
CreatedBy: 1
,CreatedDate: 1
,Id: 1
,IsActive: true
,ModeOfArrivalId: 1
,ModifiedBy: 1
,Modified_Date: 1
,PatientId: 1
,PreArvlNote: 1
,PreArvlTime: 1
,RefFrom: 1
,RevisitReason: 1
,TraigeDoneby: 1
,TriageTime: 1
            };
        }
    }
    db[tableName].put(record)
    .then(function (data) {
        
    })
    .catch(function (error) {
        console.log(error);
    });;
}

function selectAllData(tableName) {
    var records = [];
    db[tableName].each(function (record) { records.push(record); });
    return records;
}

//db.table1.filter(function(record){ return record.Id == 1;}).each(function(data){console.log(data);});
//db.table2.update(7, { Name: 'Srinivas R' });
//db.table2.delete(7);
//db.table2.clear();


function syncToServer() {

    //loop through all the tables one by one
    //for each table loop thorugh all records on sucessfull update in server then we need to delete the record from local db, 
    //if there is any error keep the record in local and mark as error

    //in progress

}