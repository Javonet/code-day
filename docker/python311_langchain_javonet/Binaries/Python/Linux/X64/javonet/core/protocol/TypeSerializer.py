import struct

from javonet.utils.Type import Type
from javonet.utils.StringEncodingMode import StringEncodingMode


class TypeSerializer:

    @staticmethod
    def serialize_type(type_value):
        return TypeSerializer.serialize_int(type_value)

    @staticmethod
    def serialize_int(int_value):
        encoded_int_list = list(bytearray(struct.pack("<i", int_value)))
        length = len(encoded_int_list)
        return [Type.JavonetInteger.value, length] + encoded_int_list

    @staticmethod
    def serialize_unsigned_int(unsigned_int_value):
        encoded_unsigned_int_list = list(bytearray(struct.pack("<I", unsigned_int_value)))
        length = len(encoded_unsigned_int_list)
        return [Type.JavonetUnsignedInteger.value, length] + encoded_unsigned_int_list

    @staticmethod
    def serialize_longlong(longlong_value):
        encoded_longlong_list = list(bytearray(struct.pack("<q", longlong_value)))
        length = len(encoded_longlong_list)
        return [Type.JavonetLongLong.value, length] + encoded_longlong_list

    @staticmethod
    def serialize_unsignedlonglong(unsigned_longlong_value):
        encoded_unsignedlonglong_list = list(bytearray(struct.pack("<q", unsigned_longlong_value)))
        length = len(encoded_unsignedlonglong_list)
        return [Type.JavonetUnsignedLongLong.value, length] + encoded_unsignedlonglong_list

    @staticmethod
    def serialize_double(double_value):
        encoded_double_list = list(bytearray(struct.pack("<d", double_value)))
        length = len(encoded_double_list)
        return [Type.JavonetDouble.value, length] + encoded_double_list

    @staticmethod
    def serialize_string(string_value):
        encoded_string_list = list(bytearray(string_value, 'utf-8'))
        length = list(bytearray(struct.pack("<i", len(encoded_string_list))))
        return [Type.JavonetString.value] + [StringEncodingMode.UTF8.value] + length + encoded_string_list

    @staticmethod
    def serialize_float(float_value):
        encoded_float_list = list(bytearray(struct.pack("<f", float_value)))
        length = len(encoded_float_list)
        return [Type.JavonetFloat.value, length] + encoded_float_list

    @staticmethod
    def serialize_bool(bool_value):
        encoded_bool_list = list(bytearray(struct.pack("?", bool_value)))
        length = len(encoded_bool_list)
        return [Type.JavonetBoolean.value, length] + encoded_bool_list

    @staticmethod
    def serialize_char(char_value):
        encoded_char_list = list(bytearray(struct.pack("<c", char_value)))
        length = len(encoded_char_list)
        return [Type.JavonetChar.value, length] + encoded_char_list

    @staticmethod
    def serialize_bytes(bytes_value):
        encoded_bytes_list = list(bytearray(struct.pack("<s", bytes_value)))
        length = len(encoded_bytes_list)
        return [Type.JavonetBytes.value, length] + encoded_bytes_list

    @staticmethod
    def serialize_command(command):
        length = list(bytearray(struct.pack("<i", len(command.payload))))
        return [Type.Command.value] + length + [command.runtime_name.value, command.command_type.value]
