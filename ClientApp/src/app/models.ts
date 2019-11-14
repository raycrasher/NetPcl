export class Result<T> {
    ok:boolean;
    message:string;
    data:T;
}

export class Model {
    id: number = 0;
    needsSaving:boolean = false;
    needsLoading:boolean = false;
}

export class Level extends Model {
    
    name: string;
}

export class Factor  extends Model {
    
    name: string;
    levels: Level[];
}

export class TestSheet  extends Model {
    
    name: string;
    factors: Factor[];
}

export class TestSuite  extends Model {
    
    name: string;
    description: string;
    sheets: TestSheet[] = [];

}