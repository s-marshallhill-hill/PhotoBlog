import { Http } from '@angular/http';
import { Entry } from './entry.model'
import { Injectable } from '@angular/core';

@Injectable() 
export class EntryService {
    constructor (private http: Http){

    }
    getEntries() : Promise<Entry[]>{
        return this.http.get('/api/photo')
                    .toPromise()
                    .then(response => response.json().data as Entry[]);
    }
}