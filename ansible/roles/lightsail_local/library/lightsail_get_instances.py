  
#!/usr/bin/python
# -*- coding: utf-8 -*-
# Copyright: Gencebay Demir

from __future__ import absolute_import, division, print_function
__metaclass__ = type


ANSIBLE_METADATA = {'metadata_version': '1.1',
                    'status': ['preview'],
                    'supported_by': 'community'}

import time

try:
    import botocore
except ImportError:
    # will be caught by AnsibleAWSModule
    pass

from ansible.module_utils.aws.core import AnsibleAWSModule
from ansible.module_utils.ec2 import camel_dict_to_snake_dict

def get_instances(module, client):
    """
    Get lightsail existing instances
    Wait will not apply here as this is an OS-level operation
    """

    changed = False
    instances= dict()

    try:
        instances = client.get_instances()
        changed = True
    except botocore.exceptions.ClientError as e:
        module.fail_json_aws(e)

    module.exit_json(changed=changed, instances=camel_dict_to_snake_dict(instances))

def main():

    argument_spec = dict(
        wait=dict(type='bool', default=True),
        wait_timeout=dict(default=300, type='int'),
    )

    module = AnsibleAWSModule(argument_spec=argument_spec)

    client = module.client('lightsail')

    get_instances(module, client)


if __name__ == '__main__':
    main()