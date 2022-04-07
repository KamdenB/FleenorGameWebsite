import React, { Component } from 'react';
import { Button, FormGroup, Input } from 'reactstrap';

export class SearchUsers extends Component {
  render () {
    return (
      <div>
        <FormGroup>
            <Input placeholder="Enter a username" />
        </FormGroup>
      </div>
    );
  }
}
