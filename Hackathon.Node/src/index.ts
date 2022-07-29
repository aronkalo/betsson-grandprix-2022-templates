#!/usr/bin/env node

import map from './map.json';
import { Position } from './position';
import { Map } from './map';
import fs from 'fs';

console.log(`Input: ${JSON.stringify(map)}`);

try {
    const mapObject: Map = map;
    const movement = calculateMovement(mapObject);
    
    const resultString = JSON.stringify(movement);
    console.log(`Output: ${resultString}`);
    fs.writeFileSync('./result.json', resultString, 'utf-8');
}
catch(error) {
    console.error(error);
}


function calculateMovement(map: Map) : Position[] {
    // TODO implement your changes here
    return [ { x: 0, y: 0 } ];
}