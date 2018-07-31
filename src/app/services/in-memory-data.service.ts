import { InMemoryDbService, RequestInfo, STATUS } from 'angular-in-memory-web-api';
import { ResponseOptions } from '@angular/http';

const targetScores = [
  { id: 1, score: 0 },
  { id: 2, score: 4 },
  { id: 3, score: 2 },
  { id: 4, score: 1 },
  { id: 5, score: 10 },
  { id: 6, score: 8 },
  { id: 7, score: 9 },
  { id: 8, score: 5 },
  { id: 9, score: 6 },
  { id: 10, score: 3 }
];

export class InMemoryDataService implements InMemoryDbService {
  
  createDb() {
    // const targetScores = [
    //   { id: 1, score: 0 },
    //   { id: 2, score: 4 },
    //   { id: 3, score: 2 },
    //   { id: 4, score: 1 },
    //   { id: 5, score: 10 },
    //   { id: 6, score: 8 },
    //   { id: 7, score: 9 },
    //   { id: 8, score: 5 },
    //   { id: 9, score: 6 },
    //   { id: 10, score: 3 }
    // ];
    return {targetScores};
  }

  post(reqInfo: RequestInfo){
    const collectionName = reqInfo.collectionName;
    if(collectionName === 'targetScores'){
      const data = reqInfo.utils.getJsonBody(reqInfo.req);
      targetScores.push({id: targetScores.slice(-1).pop().id + 1, score: data});
      return reqInfo.utils.createResponse$(() =>{
        const options: ResponseOptions = new ResponseOptions(
          {
            body: targetScores,
            status: STATUS.OK
          }
        );
        return options;
      }
    )
    }
  }
}
