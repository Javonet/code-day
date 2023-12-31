from javonet.core.handler.CommandHandler.AbstractCommandHandler import *


class SetInstanceFieldHandler(AbstractCommandHandler):

    def __init__(self):
        self._required_parameters_count = 3

    def process(self, command):
        try:
            if len(command.payload) < self._required_parameters_count:
                raise Exception("SetInstanceFieldHandler parameters mismatch!")
            instance = command.payload[0]
            field = command.payload[1]
            new_value = command.payload[2]
            setattr(instance, field, new_value)
            return 0
        except Exception as e:
            exc_type, exc_value = type(e), e
            new_exc = exc_type(exc_value).with_traceback(e.__traceback__)
            raise new_exc from None

